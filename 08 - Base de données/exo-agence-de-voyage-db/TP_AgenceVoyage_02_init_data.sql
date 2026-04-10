INSERT INTO country 
(country_code, country_name)
VALUES 
	('FR', 'France'),
   ('DE', 'Allemagne'),
   ('BE', 'Belgique'),
   ('IT', 'Italie'),
   ('MA', 'Maroc'),
   ('UA', 'Ukraine'),
   ('GB', 'Ecosse');

/* EN cas de clé primaire auto-incrémenté, ne pas écrire le nom de la colonne et pas de valeur dans VALUES*/
INSERT INTO city 
(city_name, country_code)
VALUES
('Paris','FR'),
('Mulhouse','FR'),
('Rust','DE'),
('Bruxelles','BE'),
('Milan','IT'),
('Rome','IT'),
('Chernobyl','UA'),
('Édimbourg','GB');


INSERT INTO service 
(service_name, service_description)
VALUES 
('All inclusive', 'tout compris'),
("Service d'étage",NULL),
('Piscine',NULL),
('Piscine chauffée',NULL),
('Coach sportif',NULL),
('Pratique du golf',NULL);

/*comme le commercial n'existe pas, on pouvait mettre des remplacant. donc on créé un commercant, on le remplace par lui meme. puis on fait les 4 autres entrées et on remodifie la ligne 1*/
INSERT INTO com 
(com_code, com_name, com_password, com_code_1)
VALUES
   ('COM01', 'Sophie Dubois', 'Pass123!', 'COM01'),

INSERT INTO com 
(com_code, com_name, com_password, com_code_1)
VALUES
   ('COM02', 'Marc Lefebvre', 'SecurePass456', 'COM01'),
   ('COM03', 'Julie Martin', 'Tech@2024', 'COM02'),
   ('COM04', 'Thomas Bernard', 'Green$Energy', 'COM04'),
   ('COM05', 'Marie Rousseau', 'BelleVue789', 'COM05');
   
UPDATE com SET com_code_1 = 'COM03' WHERE com_code='COM01';

