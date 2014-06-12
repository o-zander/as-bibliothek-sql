/* Addresses */
SET IDENTITY_INSERT T_Addresses ON;
INSERT INTO T_Addresses (p_address_id)
VALUES (1);
SET IDENTITY_INSERT T_Addresses OFF;

/* Library */
INSERT INTO T_Libraries (f_address_id, name, loan_period, charge, yearly_fee)
VALUES (1, 'Beispiel-Bibliothek', 30, '1.00', '30.00');

/* Rights */
SET IDENTITY_INSERT T_Rights ON;
INSERT INTO T_Rights (p_right_id, title)
VALUES (1, 'Bibliothek bearbeiten'), (2, 'B�cher hinzuf�gen'), (3, 'B�cher verleihen'), (4, 'Personen hinzuf�gen'), (5, 'Konten bearbeiten');
SET IDENTITY_INSERT T_Rights OFF;

/* Admin */
EXECUTE create_person 'Admin', 'Istrator', NULL, NULL, NULL, NULL, NULL, NULL;
