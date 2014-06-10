/* Library */
SET IDENTITY_INSERT T_Addresses ON;
INSERT INTO T_Addresses (p_address_id)
VALUES (1);
INSERT INTO T_Libraries (f_address_id, name, loan_period, charge, yearly_fee)
VALUES (1, 'Beispiel-Bibliothek', 30, '1.00', '30.00');

/* Rights */
SET IDENTITY_INSERT T_Rights ON;
INSERT INTO T_Rights (p_right_id, title)
VALUES (1, 'Bibliothek bearbeiten'), (2, 'Bücher hinzufügen'), (3, 'Bücher verleihen'), (4, 'Personen hinzufügen'), (5, 'Konten bearbeiten');

/* Persons */
EXECUTE create_person 'Kristina', 'Pusch', '25-04-1994', 'Frankfurter Allee', '216', '10365', 'Berlin', 'Deutschland'; 
EXECUTE create_person 'Oliver', 'Zander', '04-02-1990', 'Gelsenkircher Str.', '23', '13583', 'Berlin', 'Deutschland';

EXECUTE create_person 'Heinz', 'Müller', '07-06-1987', 'Frankestraße', '2', '31515', 'Wunstorf', 'Deutschland';
EXECUTE create_person 'Magdalena', 'Heinrich', '19-02-1993', 'An der Nikolaikirche', '7b', '10624', 'Berlin', 'Deutschland';
EXECUTE create_person 'Nina', 'Meier', '12-03-1990', 'Hauptstraße', '20', '10365', 'Berlin', 'Deutschland';


/* Grant rights */
EXECUTE grant_all_rights 1;
EXECUTE grant_all_rights 2;

/* Books */
EXECUTE create_book 'Der Seele weißes Blut', 'Thriller';
EXECUTE create_book 'Isola', 'Thriller';
EXECUTE create_book 'Lucian', 'Roman';
EXECUTE create_book 'Der Hundertjährige, der aus dem Fenster sprang und verschwand', 'Roman';
EXECUTE create_book 'Das Leuchten der Stille', 'Roman';

/* Author */
EXECUTE create_author 'Sabine', 'Klewe';
EXECUTE create_author 'Isabel', 'Abedi';
EXECUTE create_author 'Jonas', 'Jonasson';
EXECUTE create_author 'Nicholas', 'Sparks';

/* Link Author */
EXECUTE link_author_book 1, 1; 
EXECUTE link_author_book 2, 2;
EXECUTE link_author_book 2, 3; 
EXECUTE link_author_book 3, 4; 
EXECUTE link_author_book 4, 5;  

/* Exemplars */
EXECUTE create_exemplars 1, 3 ;
EXECUTE create_exemplars 2, 10 ;
EXECUTE create_exemplars 3, 2 ;
EXECUTE create_exemplars 4, 4 ;
EXECUTE create_exemplars 5, 2 ;
