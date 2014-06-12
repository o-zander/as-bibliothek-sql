/* Mitarbeiter anlegen */
EXECUTE create_person 'Kristina', 'Pusch', '25-04-1994', 'Frankfurter Allee', '216', '10365', 'Berlin', 'Deutschland';
EXECUTE grant_all_rights 1; 
EXECUTE create_person 'Oliver', 'Zander', '04-02-1990', 'Gelsenkircher Str.', '23', '13583', 'Berlin', 'Deutschland';
EXECUTE grant_all_rights 2;

/* Autoren anlegen */
EXECUTE create_author 'Sabine', 'Klewe';
EXECUTE create_author 'Isabel', 'Abedi';
EXECUTE create_author 'Jonas', 'Jonasson';
EXECUTE create_author 'Nicholas', 'Sparks';

/* B�cher anlegen */
EXECUTE create_book 'Der Seele wei�es Blut', 'Thriller';
EXECUTE create_book 'Isola', 'Thriller';
EXECUTE create_book 'Lucian', 'Roman';
EXECUTE create_book 'Der Hundertj�hrige, der aus dem Fenster stieg und verschwand', 'Roman';
EXECUTE create_book 'Das Leuchten der Stille', 'Roman';

/* Autoren und B�cher verkn�pfen */
EXECUTE link_author_book 1, 1; 
EXECUTE link_author_book 2, 2;
EXECUTE link_author_book 2, 3; 
EXECUTE link_author_book 3, 4; 
EXECUTE link_author_book 4, 5;

/* Exemplare hinzuf�gen */
EXECUTE create_exemplars 1, 3;
EXECUTE create_exemplars 2, 10;
EXECUTE create_exemplars 3, 1;
EXECUTE create_exemplars 4, 4;
EXECUTE create_exemplars 5, 2;

/* Kunden anlegen */
EXECUTE create_person 'Heinz', 'M�ller', '07-06-1987', 'Frankestra�e', '2', '31515', 'Wunstorf', 'Deutschland';
EXECUTE create_person 'Magdalena', 'Heinrich', '19-02-1993', 'An der Nikolaikirche', '7b', '10624', 'Berlin', 'Deutschland';
EXECUTE create_person 'Nina', 'Meier', '12-03-1990', 'Hauptstra�e', '20', '10365', 'Berlin', 'Deutschland';

/* Heinz M�ller leiht sich Lucian aus */
EXECUTE lend_book 4, 3;

/* Magdalena Heinrich bestellt sich Lucian vor */
EXECUTE reserve_book 5, 3;

/* die Jahresgeb�hr von Nina Meier wird f�llig */
EXECUTE charge_yearly_fee 6;