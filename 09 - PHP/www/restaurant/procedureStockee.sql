USE guide;

/*Procécure stockée pour afficher la liste par rapport à une note limite */

DELIMITER |
CREATE PROCEDURE afficherListeNote (IN p_limite DOUBLE )
BEGIN
SELECT id, nom, adresse, prix, commentaire, note, visite AS "date de visite" 
FROM restaurants
WHERE note>=p_limite;
END|
DELIMITER ;

SET @note_limite:=10;
CALL afficherListeNote(@note_limite);


/* Procécure stockée pour afficher la liste dans un intervalle de prix */

DELIMITER | 
CREATE PROCEDURE afficherListeParPrix (IN p_prixMin DOUBLE, IN p_prixMax DOUBLE)
BEGIN 
SELECT 
    id, 
    nom, 
    adresse, 
    prix, 
    commentaire, 
    note, 
    visite AS "date de visite" 
FROM 
    restaurants 
WHERE 
    prix BETWEEN p_prixMin AND p_prixMax ;

END |
DELIMITER ;

CALL afficherListeParPrix ( 20, 50) ;
