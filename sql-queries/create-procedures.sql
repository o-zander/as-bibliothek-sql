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
      
      INSERT INTO T_Persons (f_address_id, f_identity_number, f_account_id, first_name, last_name, day_of_birth)
      VALUES (
        IDENT_CURRENT('T_Address'), IDENT_CURRENT('T_IdentityCards'), IDENT_CURRENT('T_Accounts'),
        @first_name, @last_name, @day_of_birth 
      );
    END;
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
    INSERT INTO T_AuthorsBook ()
    VALUES (); /* FIXME */
GO