CREATE TABLE REALISATIONS(
   id_rea INT UNSIGNED NOT NULL,
   titre_rea VARCHAR(250) NOT NULL,
   date_rea DATE NOT NULL,
   texte_rea TEXT NOT NULL
);

/*ajout de la clé primaire et de l'auto-incrémentation */

ALTER TABLE realisations
	ADD CONSTRAINT PK_id_rea PRIMARY KEY (id_rea);

ALTER TABLE realisations
	CHANGE COLUMN id_rea id_rea INT UNSIGNED NOT NULL AUTO_INCREMENT;
	
	

	
	
CREATE TABLE IMAGES(
   id_img INT UNSIGNED,
   url_img VARCHAR(250) NOT NULL,
   nom_img VARCHAR(100) NOT NULL,
   text_img VARCHAR(300) NOT NULL,
   ext_img VARCHAR(5) NOT NULL
);

/*ajout de la clé primaire et de l'auto-incrémentation */

ALTER TABLE images
	ADD CONSTRAINT PK_id_img PRIMARY KEY(id_img);

ALTER TABLE images
	CHANGE COLUMN id_img id_img INT UNSIGNED NOT NULL AUTO_INCREMENT;
	
	
/*ajout de la clé étrangère pour l'image principale dans la table images*/

ALTER TABLE images 
	ADD COLUMN id_img_principale INT UNSIGNED;

ALTER TABLE images 
	ADD CONSTRAINT FK_id_img_principale FOREIGN KEY(id_img_principale) REFERENCES images(id_img);






/*ajout table de liaison*/

CREATE TABLE AFFICHAGE(
	id_rea INT UNSIGNED,
	id_img INT UNSIGNED, 
	PRIMARY KEY(id_rea, id_img),
	FOREIGN KEY (id_rea) REFERENCES realisations(id_rea),
	FOREIGN KEY (id_img) REFERENCES images(id_img)
);


