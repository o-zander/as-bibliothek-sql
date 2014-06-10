  create table T_Addresses(
    p_address_id int identity(1,1) primary key,
    street varchar(255),
    house_number varchar(10),
    postal varchar(5),
    city varchar(255),
    country varchar(255)
  );
  
  create table T_Libraries(
    p_library_id int identity(1,1) primary key,
    f_address_id int not null,
    name varchar(255),
    loan_period int,
    charge decimal(8,2),
    yearly_fee decimal(8,2)
    
    constraint LibraryAdressFk
      foreign key(f_address_id)
        references T_Addresses(p_address_id)
  );
  
  create table T_OpeningHours(
    p_opening_id int identity(1,1) primary key,
    f_library_id int,
    week_day varchar(255),
    opening time,
    closing time,
    
    constraint LibraryOpeningHoursFk
      foreign key(f_library_id)
        references T_Libraries(p_library_id)
  );
  
  create table T_IdentityCards(
    p_identity_number int identity(1,1) primary key,
    issue_date date,
    card_status varchar(255)
  );
  
  create table T_Accounts(
    p_account_id int identity(1,1) primary key,
    balance decimal(8,2)
  );
   
  create table T_Persons(
    p_person_id int identity(1,1) primary key,
    f_address_id int not null,
    f_identity_number int not null,
    f_account_id int not null,
    
    first_name varchar(255),
    last_name varchar(255),
    day_of_birth date,
    username varchar(255),
    pass_word varchar(255),
    
    constraint PersonsAddressFk 
      foreign key(f_address_id)
        references T_Addresses(p_address_id),
    
    constraint PersonsIdentityFk
      foreign key(f_identity_number)
        references T_IdentityCards(p_identity_number),
    
    constraint PersonsAccount
      foreign key(f_account_id)
        references T_Accounts(p_account_id)     
  );
  
  create table T_Rights(
    p_right_id int identity(1,1) primary key,
    title varchar(255)
  );

  create table T_Authors(
    p_author_id int identity(1,1) primary key,
    first_name varchar(255),
    last_name varchar(255)
  );
  
  create table T_Books(
    p_book_id int identity(1,1) primary key,
    title varchar(255),
    field varchar(255)
  );
  
  create table T_Exemplars(
    p_signature varchar(255),
    p_f_book_id int not null,
    exemplar_status varchar(255),
    
    primary key (p_signature, p_f_book_id), 
    
    constraint BooksExemplarFk
      foreign key(p_f_book_id)
        references T_Books(p_book_id)
  );
  
  /* Beziehungstabellen */
  create table T_AuthorsBooks(
    p_f_book_id int not null,
    p_f_author_id int not null,
    
    primary key  (p_f_book_id, p_f_author_id),
    
    foreign key (p_f_book_id)
      references T_Books(p_book_id),
    
    foreign key (p_f_author_id)
      references T_Authors(p_author_id)
  );
  
  create table T_Reservations(
    p_f_person_id int,
    p_f_book_id int,
    reservation_date date,
    
    primary key (p_f_person_id, p_f_book_id),
    
    constraint ReservationsBookFk
      foreign key (p_f_book_id)
        references T_Books(p_book_id),
    
    constraint ReservationsPersonFk
      foreign key (p_f_person_id)
        references T_Persons(p_person_id)
  );
  
  create table T_Borrowed(
    p_f_signature varchar(255),
    p_f_book_id int,
    f_person_id int,
    borrow_date date,
    
    primary key (p_f_signature, p_f_book_id),
    
    constraint ExemplarBorrowedFk
      foreign key (p_f_signature, p_f_book_id)
        references T_Exemplars(p_signature, p_f_book_id),
    
    constraint PersonBorrowedFk
      foreign key (f_person_id)
        references T_Persons(p_person_id)
  );
 
  create table T_PersonHasRights( 
    p_f_right_id int,
    p_f_person_id int,
    
    primary key (p_f_right_id,p_f_person_id),
    
    constraint PersonsRightsFk
      foreign key (p_f_person_id)
        references T_Persons(p_person_id),
    
    constraint RightsFk
      foreign key (p_f_right_id)
        references T_Rights(p_right_id)
  );