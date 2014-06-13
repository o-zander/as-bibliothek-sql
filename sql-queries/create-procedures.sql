CREATE PROCEDURE create_person
  /* Personinformation */
  @first_name varchar(255), @last_name varchar(255), @day_of_birth date,
  /* Addressinformation */
  @street varchar(255), @house_number varchar(10), @postal varchar(5), @city varchar(255), @country varchar(255) 
  AS
    BEGIN
      INSERT INTO T_Addresses (street, house_number, postal, city, country)
      VALUES (@street, @house_number, @postal, @city, @country);
    
      INSERT INTO T_IdentityCards (issue_date, card_status)
      VALUES (GETDATE(), 'Erstellt');
    
      INSERT INTO T_Accounts (balance)
      VALUES ('0.0');
      
      DECLARE @username varchar(7) = RIGHT('0000000' + CAST(IDENT_CURRENT('T_IdentityCards') AS varchar), 7);
    
      INSERT INTO T_Persons (f_address_id, f_identity_number, f_account_id, first_name, last_name, day_of_birth, username, pass_word)
      VALUES (
        IDENT_CURRENT('T_Addresses'), IDENT_CURRENT('T_IdentityCards'), IDENT_CURRENT('T_Accounts'),
        @first_name, @last_name, @day_of_birth, @username, @day_of_birth /* Geburtsdatum als initiales Passwort */  
      );
    END
GO

CREATE PROCEDURE grant_right
  @person int, @right int

  AS
    INSERT INTO T_PersonHasRights (p_f_person_id, p_f_right_id)
    VALUES (@person, @right);
GO

CREATE PROCEDURE grant_all_rights
  @person int

  AS
    INSERT INTO T_PersonHasRights (p_f_person_id, p_f_right_id)
    SELECT @person, R.p_right_id
    FROM T_Rights AS R;
GO

CREATE PROCEDURE revoke_right
  @person int, @right int

  AS
    DELETE FROM T_PersonHasRights
    WHERE p_f_person_id = @person AND p_f_right_id = @right;
GO

CREATE PROCEDURE has_right
  @person int, @right int

  AS
    SELECT 1
    FROM T_PersonHasRights
    WHERE p_f_person_id = @person AND p_f_right_id = @right;
GO

CREATE PROCEDURE create_book
  @title varchar(255), @field varchar(255)
  
  AS
    INSERT INTO T_Books (title, field) 
    VALUES (@title, @field);
GO

CREATE PROCEDURE create_author
  @first_name varchar(255), @last_name varchar(255)
  
  AS 
    INSERT INTO T_Authors (first_name, last_name)
    VALUES (@first_name, @last_name);
GO

CREATE PROCEDURE link_author_book
  @author int, @book int
  
  AS
    INSERT INTO T_AuthorsBooks (p_f_book_id, p_f_author_id)
    VALUES (@book, @author);
GO

CREATE PROCEDURE create_exemplars
  @book int, @count int, @status varchar(255) = 'Neu'

  AS
    BEGIN
      DECLARE @field varchar(2) = '', @author varchar(1) = '', @signature varchar(255), @timestamp int;

      SELECT @field = UPPER(field)
      FROM T_Books
      WHERE p_book_id = @book

      SELECT TOP 1 @author = UPPER(A.last_name)
      FROM T_Authors AS A
        JOIN T_AuthorsBooks AS AB ON A.p_author_id = AB.p_f_author_id
      WHERE AB.p_f_book_id = @book

      WHILE @count > 0
        BEGIN
          SET @timestamp = DATEDIFF(SECOND, '1970-01-01', CURRENT_TIMESTAMP);
          SET @signature = @field + @author + CAST(@book as varchar) + CAST(@count as varchar) + CAST(@timestamp as varchar) + CAST(CURRENT_REQUEST_ID() as varchar); /* compatibility fix for MSQL 05, on +08 use CONCAT */

          INSERT INTO T_Exemplars (p_signature, p_f_book_id, exemplar_status)
          VALUES (@signature, @book, @status);
      
          SET @count -= 1;
        END
    END
GO

CREATE PROCEDURE lend_book
  @user int, @book int
  
  AS
    BEGIN
      DECLARE @exemplar varchar(255);
      
      SET @exemplar = (
        SELECT TOP 1 e.p_signature
        FROM T_Exemplars AS e
          LEFT JOIN T_Borrowed AS b
            ON e.p_signature = b.p_f_signature
            AND b.p_f_book_id = @book
        WHERE e.p_f_book_id = @book
          AND b.f_person_id IS NULL
      );

      IF @exemplar IS NULL
        BEGIN
          RAISERROR('Kein freies Exemplar vorhanden.', 16, 1)
        END
      ELSE
        BEGIN
          INSERT INTO T_Borrowed (f_person_id, p_f_signature, p_f_book_id, borrow_date)
          VALUES (@user, @exemplar, @book, CURRENT_TIMESTAMP);
        END
    END
GO

CREATE PROCEDURE reserve_book
  @user int, @book int
  
  AS
    BEGIN
      IF (
        SELECT COUNT(*)
        FROM T_Exemplars AS e
          LEFT JOIN T_Borrowed AS b
            ON (e.p_f_book_id = b.p_f_book_id AND e.p_signature = b.p_f_signature)
        WHERE e.p_f_book_id = @book
          AND b.f_person_id IS NULL
      ) > 0
        BEGIN
          RAISERROR('Es sind freie Exemplare vorhanden.', 16, 1)
        END
      ELSE
        BEGIN
          INSERT INTO T_Reservations (p_f_person_id, p_f_book_id, reservation_date)
          VALUES (@user, @book, CURRENT_TIMESTAMP);
        END
    END
GO

CREATE PROCEDURE renew_book
  @book int, @exemplar varchar(255)

  AS
    BEGIN
      UPDATE T_Borrowed
      SET renewed = renewed + 1
      WHERE p_f_signature = @exemplar
        AND p_f_book_id = @book
        AND renewed < 2;
      
      IF @@ROWCOUNT = 0
        BEGIN
          RAISERROR('Das Buch wurde bereits zwei mal ausgeliehen.', 16, 1) 
        END
    END
GO

CREATE PROCEDURE return_book
  @book int, @exemplar varchar(255), @library int = 1
  
  AS
    BEGIN
      DECLARE @loan_period int,
              @user int,
              @diff int, /* Überschreitung der Ausleihfrist in Tagen */
              @balance decimal(8,2);
              
      SET @loan_period = (
        SELECT loan_period
        FROM T_Libraries
        WHERE p_library_id = @library
      );

      SELECT @user = f_person_id, @diff = DATEDIFF(DAY, borrow_date, CURRENT_TIMESTAMP) - @loan_period * (renewed + 1)
      FROM T_Borrowed
      WHERE p_f_signature = @exemplar
        AND p_f_book_id = @book;

      IF @diff > 0
        BEGIN
          UPDATE T_Accounts
          SET balance = balance - (
            SELECT l.charge * (@diff / 7 + 1) /* pro Woche */
            FROM T_Libraries AS l
            WHERE l.p_library_id = @library
          )
          FROM T_Accounts AS a
            JOIN T_Persons AS p
              ON a.p_account_id = p.p_person_id
          WHERE p.p_person_id = @user;
        END
      
      SET @balance = (
        SELECT a.balance
        FROM T_Accounts AS a
          JOIN T_Persons AS p
            ON a.p_account_id = p.f_account_id
        WHERE p.p_person_id = @user
      );
      
      IF @balance < '0.00'
        BEGIN
          RAISERROR('Das Konto der Person ist nicht ausgeglichen. Rückgabe nicht möglich.', 16, 1)
          ROLLBACK TRANSACTION
          RETURN
        END
        
      DELETE FROM T_Borrowed
      WHERE p_f_book_id = @book
        AND p_f_signature = @exemplar;
    END
GO

CREATE PROCEDURE change_library_name
  @name varchar(255), @library int = 1

  AS
    BEGIN
      UPDATE T_Libraries
      SET name = @name
      WHERE p_library_id = @library;
    END
GO

CREATE PROCEDURE change_library_loan_period
  @loan_period int, @library int = 1
  
  AS
    BEGIN
      UPDATE T_Libraries
      SET loan_period = @loan_period
      WHERE p_library_id = @library;
    END
GO

CREATE PROCEDURE change_library_charge
  @charge decimal(8,2), @library int = 1
  
  AS
    BEGIN
      UPDATE T_Libraries
      SET charge = @charge
      WHERE p_library_id = @library;
    END
GO

CREATE PROCEDURE change_library_yearly_fee
  @yearly_fee decimal(8,2), @library int = 1
  
  AS
    BEGIN
      UPDATE T_Libraries
      SET yearly_fee = @yearly_fee
      WHERE p_library_id = @library;
    END
GO

CREATE PROCEDURE charge_yearly_fee
  @user int, @library int = 1

  AS
    BEGIN
      UPDATE T_Accounts
      SET balance = balance - (SELECT yearly_fee FROM T_Libraries WHERE p_library_id = @library)
      FROM T_Accounts AS a
        JOIN T_Persons AS p
          ON a.p_account_id = p.f_account_id
      WHERE p.p_person_id = @user;
    END
GO

CREATE PROCEDURE add_library_opening_hour
  @week_day varchar(255), @opening time(7), @closing time(7), @library int = 1

  AS
    BEGIN
      IF @opening >= @closing
        BEGIN
          RAISERROR('Die Startzeit ist größer oder gleich der Endzeit!', 16, 1)
          RETURN
        END

      IF EXISTS (
        SELECT 1
        FROM T_OpeningHours
        WHERE f_library_id = @library
          AND ((@opening <= opening AND @opening >= closing) OR (@closing >= opening AND @closing <= closing))
      )
        BEGIN
          RAISERROR('Es existiert eine überlappende Öffnungszeit.', 16, 1)
          RETURN
        END 
        
      INSERT INTO T_OpeningHours (f_library_id, week_day, opening, closing)
      VALUES (@library, @week_day, @opening, @closing);
    END
GO

CREATE PROCEDURE remove_library_opening_hour
  @opening_hour int

  AS
    BEGIN
      DELETE FROM T_OpeningHours
      WHERE p_opening_id = @opening_hour;
    END
GO