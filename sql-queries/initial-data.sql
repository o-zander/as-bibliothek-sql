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

/* Grant rights */
EXECUTE grant_all_rights 1;
EXECUTE grant_all_rights 2;