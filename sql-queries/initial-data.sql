/* Rights */
INSERT INTO T_Rights (p_right_id, title)
VALUES (1, 'Bibliothek bearbeiten'), (2, 'B�cher hinzuf�gen'), (3, 'B�cher verleihen'), (4, 'Personen hinzuf�gen'), (5, 'Konten bearbeiten');

/* Persons */
EXECUTE create_person 'Kristina', 'Pusch', '25-04-1994', 'Frankfurter Allee', '216', '10365', 'Berlin', 'Deutschland'; 
EXECUTE create_person 'Oliver', 'Zander', '04-02-1990', 'Gelsenkircher Str.', '23', '13583', 'Berlin', 'Deutschland';

/* Grant rights */
EXECUTE grant_all_rights (SELECT p_person_id FROM T_Persons WHERE first_name = 'Kristina' AND last_name = 'Pusch');
EXECUTE grant_all_rights (SELECT p_person_id FROM T_Persons WHERE first_name = 'Oliver' AND last_name = 'Zander'); 