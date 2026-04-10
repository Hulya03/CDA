/*1.*/

SELECT 
	client_ref, 
	client_nom
FROM clients
WHERE client_telephone LIKE '04%';
	
/*2.*/

SELECT 
	client_ref,
	client_nom,
	type_client_libelle
FROM clients 
INNER JOIN type_clients ON clients.type_client_id = type_clients.type_client_id
WHERE type_client_libelle = (
	SELECT type_client_libelle 
	FROM type_clients
	WHERE type_client_libelle = 'Particulier'
	)
;

/*3.*/

SELECT 
	client_ref,
	client_nom,
	type_client_libelle
FROM clients 
INNER JOIN type_clients ON clients.type_client_id = type_clients.type_client_id
WHERE type_client_libelle <> (
	SELECT type_client_libelle 
	FROM type_clients
	WHERE type_client_libelle = 'Particulier'
	)
;

/*4. Projets en retard. 
j'admets que valeur 'null' signifie que les travaux sont toujours en cours*/

SELECT 
	projet_ref
FROM projets 
WHERE projet_date_fin_effective > projet_date_fin_prevue OR projet_date_fin_effective IS NULL
;

/*5.*/

SELECT 
	projet_date_depot,
	projet_date_fin_prevue,
	projet_superficie_totale,
	projet_superficie_batie,
	projet_prix,
	client_nom,
	emp_nom,
	emp_prenom
FROM projets
INNER JOIN employes ON projets.emp_matricule = employes.emp_matricule
INNER JOIN clients ON projets.client_ref = clients.client_ref
;

/*6.*/

SELECT
	projet_date_depot,
	projet_date_fin_prevue,
	projet_superficie_totale,
	projet_superficie_batie,
	projet_prix,
	COUNT(participer.emp_matricule) AS nb_intervenant
FROM projets 
INNER JOIN participer ON projets.projet_ref = participer.projet_ref
GROUP BY participer.projet_ref
;


/*7.*/

SELECT 
	type_projet_libelle, 
	COUNT(projet_ref),
	AVG(projet_prix)
FROM type_projets
INNER JOIN projets ON type_projets.type_projet_id = projets.type_projet_id
GROUP BY projets.type_projet_id
;

/*8.*/

SELECT 
	projets.type_travaux_id,
	type_travaux_libelle,
	MAX(projet_superficie_totale)
FROM type_travaux
INNER JOIN projets ON type_travaux.type_travaux_id = projets.type_travaux_id
GROUP BY projets.type_travaux_id
;

/*9.*/

SELECT 
	projet_date_depot,
	projet_date_fin_prevue,
	projet_prix,
	client_nom, 
	client_telephone,
	adresse_num_voie,
	adresse_voie,
	adresse_code_postal,
	adresse_ville,
	type_travaux_libelle,
	type_projet_libelle
FROM projets 
INNER JOIN clients ON projets.client_ref = clients.client_ref
INNER JOIN adresses ON clients.adresse_id = adresses.adresse_id
INNER JOIN type_travaux ON projets.type_travaux_id = type_travaux.type_travaux_id
INNER JOIN type_projets ON projets.type_projet_id = type_projets.type_projet_id
;

/*10.*/

SELECT 
	projets.projet_ref
FROM projets
INNER JOIN clients ON projets.client_ref = clients.client_ref
INNER JOIN adresses ON clients.adresse_id = adresses.adresse_id
WHERE projets.adresse_id = clients.adresse_id
;