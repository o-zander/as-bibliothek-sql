CREATE PROCEDURE T_Persons.create_person
  /* Personinformation */
  @first_name varchar(255), @last_name varchar(255), @day_of_birth date,
  /* Addressinformation */
  @street varchar(255), @postal varchar(5), @country varchar(255), @city varchar(255), @house_number varchar(10)
  AS
    BEGIN
      INSERT INTO T_Address (street, postal, country, city, house_number)
      VALUES (@street, @postal, @country, @city, @house_number)
      
    END
    