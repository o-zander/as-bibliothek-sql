CREATE PROCEDURE create_person
  /* Personinformation */
  @first_name varchar(255), @last_name varchar(255), @day_of_birth date,
  /* Addressinformation */
  @street varchar(255), @house_number varchar(10), @postal varchar(5), @city varchar(255), @country varchar(255) 
  AS
    BEGIN
      INSERT INTO T_Address (street, house_number, postal, city, country)
      VALUES (@street, @house_number, @postal, @city, @country);
    
      INSERT INTO T_IdentityCards (issue_date, card_status)
      VALUES (GETDATE(), 'Erstellt');
    
      INSERT INTO T_Accounts (balance)
      VALUES ('0.0');
    
      INSERT INTO T_Persons (f_address_id, f_identity_number, f_account_id, first_name, last_name, day_of_birth, username)
      VALUES (
        IDENT_CURRENT('T_Address'), IDENT_CURRENT('T_IdentityCards'), IDENT_CURRENT('T_Accounts'),
        @first_name, @last_name, @day_of_birth, IDENT_CURRENT('T_IdentityCards') 
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
      IF @count > 0
        BEGIN
          DECLARE @field varchar(2), @author varchar(1), @signature varchar(255), @timestamp int;

          SET @field = (
            SELECT UPPER(field)
            FROM T_Books
            WHERE p_book_id = @book
          );

          SET @author = (
            SELECT TOP 1 UPPER(A.last_name)
            FROM T_Authors AS A
              JOIN T_AuthorsBooks AS AB ON A.p_author_id = AB.p_f_author_id
            WHERE AB.p_f_book_id = @book
          );

          SET @timestamp = DATEDIFF(SECOND, '1970-01-01', CURRENT_TIMESTAMP);

          SET @signature = CONCAT(@field, @author, @book, @count, @timestamp, CURRENT_REQUEST_ID());

          INSERT INTO T_Exemplars (p_signature, p_f_book_id, exemplar_status)
          VALUES (@signature, @book, @status);
      
          SET @count = @count - 1;
          EXECUTE create_exemplars @book, @count, @status;
        END
    END
GO