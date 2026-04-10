/* 1. Sélectionner tous les employés (codeEmpl, nom, salaire) triés par nom et par ordre alphabétique */ 

SELECT codeEmpl, nom, salaire  
FROM employe
ORDER BY nom ASC
;

/* 2. Sélectionner tous les employés (codeEmpl, nom, salaire) avec, pour chaque employé, le nom du rayon dans lequel il travaille */

SELECT codeEmpl, nom, salaire, nomR 
FROM employe
;

/*version en procédure stockée

1. Création PROCEDURE ET MISE EN PLACE DU DELIMITEUR: 

DELIMITER | 

CREATE PROCEDURE afficher_employe()
	BEGIN 
		SELECT codeEmpl, nom, salaire, nomR 
		FROM employe
		;	
	END |	

DELIMITER ;
remise en place du délimiteur habituel pour les requetes habituelles. on change le délimiteur pour annoncer la fin de la procédure 


2.appel LA PROCEDURE :

CALL afficher_employe()

*/

/*

autre procédure avec OUT 

DELIMITER |
CREATE PROCEDURE afficher_prod_outFournisseur(IN p_codeF CHAR(6), OUT p_nomfournisseur VARCHAR(50))
BEGIN
 SELECT
  A.nomA AS "Nom Article",
  A.`type` AS "Type Article",
  A.nomR AS "Rayon",
  F.nomF AS "Nom Fournisseur" INTO p_nomfournisseur
 FROM
  ligne_bon_de_livraison AS L
 INNER JOIN
  articles AS A ON A.codeA = L.codeA
 INNER JOIN
  fournisseurs AS F ON F.codeF = L.codeF
 WHERE
 L.codeF = p_codeF;
END|
DELIMITER ;

*/




/* 3. Sélectionner tous les fournisseurs (codeFourn, nom) et le nombre de produits qu'ils fournissent, triés par nombre de produits décroissant */

SELECT 
fournisseurs.codeF, 
nomF, 
COUNT(codeA) AS nb_produits
FROM fournisseurs
INNER JOIN ligne_bon_de_livraion ON fournisseurs.codeF = ligne_bon_de_livraion.codeF
GROUP BY codeF
;

/* 4. Sélectionner le nom des produits, (leur prix), et le nom du fournisseur associé */

/* ajouter une colonne prix manquante */
ALTER table articles ADD COLUMN prix DECIMAL(5,2) NOT NULL DEFAULT '0';

/* mise a jour des prix */
UPDATE articles set prix=120 WHERE codeA='A0000001';
UPDATE articles set prix=50 WHERE codeA='A0000002';
UPDATE articles set prix=10 WHERE codeA='A0000003';
UPDATE articles set prix=1 WHERE codeA='A0000004';
UPDATE articles set prix=12 WHERE codeA='A0000005';
UPDATE articles set prix=500 WHERE codeA='A0000006';
UPDATE articles set prix=20 WHERE codeA='A0000007';
UPDATE articles set prix=40 WHERE codeA='A0000008';
UPDATE articles set prix=1.5 WHERE codeA='A0000009';
UPDATE articles set prix=3 WHERE codeA='A0000010';

SELECT nomA, prix, nomF
FROM articles
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
INNER JOIN fournisseurs ON ligne_bon_de_livraion.codeF = fournisseurs.codeF
;

/* 5. Sélectionner le nom des produits, leur prix, et le nom du fournisseur pour chaque produit dont le prix est supérieur à la moyenne des prix des produits */

SELECT nomA, prix, nomF
FROM articles
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
INNER JOIN fournisseurs ON ligne_bon_de_livraion.codeF = fournisseurs.codeF
WHERE prix > (SELECT AVG(prix) FROM articles)
;

/* On peut utiliser des sous-requêtes quand on retourne une seule valeur
	(SELECT AVG(prix) FROM articles);
*/


/* petite requête qu'on peut faire de coté pour vérifier la moyenne
	SELECT AVG (prix) FROM articles;
*/


/* 6. Sélectionner tous les employés (codeEmpl, nom). Pour chaque employé, indiquer le nom du rayon, le nombre d'articles associés au rayon  */

SELECT codeEmpl, nom, rayon.nomR, COUNT(codeA)
FROM employe
INNER JOIN rayon ON employe.nomR = rayon.nomR
INNER JOIN articles ON rayon.nomR = articles.nomR
GROUP BY codeEmpl
;

/* quand 2 tables pointent vers une meme table, on peut shinter une table => elle ira un tout ptit peu plus vite 

SELECT codeEmpl, nom, rayon.nomR, COUNT(codeA)
FROM employe
INNER JOIN articles ON employe.nomR = articles.nomR
GROUP BY codeEmpl
;
*/ 


/* 7. Sélectionner tous les articles (codeA, nomA). Pour chaque article, indiquer le nombre de livraisons et la quantité totale livrée. */

SELECT articles.codeA, nomA, COUNT(ligne_bon_de_livraion.codeA) AS nb_livraison, SUM(quantité) AS quantite_totale
FROM articles 
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
GROUP BY ligne_bon_de_livraion.codeA
;

/* 8.  Sélectionner tous les articles (codeA, nomA). Pour chaque article, indiquer le nom du fournisseur, le nom et l'étage du rayon où il est stocké, et l'employé qui y travaille (codeEmpl, nom). */

SELECT articles.codeA, nomA, nomF, rayon.nomR, etage, codeEmpl, nom
FROM articles 
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
INNER JOIN fournisseurs ON ligne_bon_de_livraion.codeF = fournisseurs.codeF
INNER JOIN rayon ON articles.nomR = rayon.nomR
INNER JOIN employe ON rayon.nomR = employe.nomR
;

 /* si on veut concaténer la liste des fournisseurs en fonction des articles */
SELECT articles.codeA AS codeA2, nomA, (SELECT GROUP_CONCAT(nomF) FROM fournisseurs INNER JOIN ligne_bon_de_livraion ON fournisseurs.codeF = ligne_bon_de_livraion.codeF WHERE ligne_bon_de_livraion.codeA = codeA2 GROUP BY codeA) AS liste_fournisseurs , etage, codeEmpl, nom
FROM articles 
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
INNER JOIN fournisseurs ON ligne_bon_de_livraion.codeF = fournisseurs.codeF
INNER JOIN rayon ON articles.nomR = rayon.nomR
INNER JOIN employe ON rayon.nomR = employe.nomR
GROUP BY codeA2
;

/*autres façon plus simple de concaténer*/
SELECT articles.codeA AS codeA2, nomA, GROUP_CONCAT(nomF) AS liste_fournisseurs , etage, codeEmpl, nom
FROM articles 
INNER JOIN ligne_bon_de_livraion ON articles.codeA = ligne_bon_de_livraion.codeA
INNER JOIN fournisseurs ON ligne_bon_de_livraion.codeF = fournisseurs.codeF
INNER JOIN rayon ON articles.nomR = rayon.nomR
INNER JOIN employe ON rayon.nomR = employe.nomR
GROUP BY codeA2
;

/* Corriger et modifer le nom d'une table 

ALTER TABLE ligne_bon_de_livraion
	RENAME ligne_bon_de_livraison;
*/
	
/* Voir toutes les tables 

SHOW TABLES; 
*/ 