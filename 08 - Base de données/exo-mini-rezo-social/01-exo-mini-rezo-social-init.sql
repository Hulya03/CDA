DROP DATABASE if EXISTS db_exo_mini_rezo_social;

CREATE DATABASE db_exo_mini_rezo_social;

USE db_exo_mini_rezo_social;

CREATE TABLE utilisateur (
	id INT, 
	nom_utilisateur VARCHAR(32) NOT NULL,
	email VARCHAR(128) NOT NULL,
	PRIMARY KEY (id),
	UNIQUE (nom_utilisateur, email)
); 

CREATE TABLE publication (
	pub_id INT AUTO_INCREMENT, 
	pub_date DATETIME NOT NULL,
	pub_titre VARCHAR(255) NOT NULL, 
	pub_contenu TEXT NOT NULL, 
	id INT NOT NULL,
	PRIMARY KEY (pub_id),
	FOREIGN KEY (id) REFERENCES utilisateur(id)
);

CREATE TABLE aimer (
	id INT,
	pub_id INT,
	PRIMARY KEY (id, pub_id),
	FOREIGN KEY (id) REFERENCES utilisateur(id),
	FOREIGN KEY (pub_id) REFERENCES publication(pub_id)
);
