CREATE TABLE REALISATIONS(
   id_rea INT UNSIGNED AUTO_INCREMENT,
   titre_rea VARCHAR(250) NOT NULL,
   date_rea DATE NOT NULL,
   texte_rea TEXT NOT NULL,
   PRIMARY KEY(id_rea)
);

CREATE TABLE IMAGES(
   id_img INT UNSIGNED AUTO_INCREMENT,
   url_img VARCHAR(250) NOT NULL,
   nom_img VARCHAR(100) NOT NULL,
   text_img VARCHAR(300) NOT NULL,
   ext_img VARCHAR(5) NOT NULL,
   PRIMARY KEY(id_img)
);

CREATE TABLE affichage(
   id_rea INT UNSIGNED,
   id_img INT UNSIGNED,
   PRIMARY KEY(id_rea, id_img),
   FOREIGN KEY(id_rea) REFERENCES REALISATIONS(id_rea),
   FOREIGN KEY(id_img) REFERENCES IMAGES(id_img)
);


/*3. Requete qui permet de trouver toutes les images associées à une id_rea fixée*/

SELECT id_img 
FROM affichage 
WHERE id_rea = 1;
