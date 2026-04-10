<?php

/**
 * Créer une fonction « getMC2() ».
 * Cette fonction doit retourner Le nom de l’inventeur de la formule « E = MC² »
 */

function getMC2() : string
{
    return "Albert Einstein";
}

echo getMC2();

/**
 * Créer une fonction « getUserName() » qui accepte deux arguments (prénom et nom) de type string.
 * Cette fonction doit retourner la concaténation des deux valeurs. 
*/

function getUserName(string $prenom, string $nom) : string
{
    return $prenom . $nom;
}

echo "\n";
echo getUserName('Hülya','Cetin');


/**
 * Créer une fonction « getFullName() » acceptant deux arguments (nom et prénom) de type string.
 * Cette fonction doit retourner la concaténation des deux valeurs avec un espace entre les 2, le prénom en minuscule et le nom
 * en MAJUSCULE.
 */

// strtoupper() : sert à mettre en majuscule
// mb_strtoupper() : sert à mettre majuscule même les é,è...

function getFullName(string $nom, string $prenom) : string
{
    return $prenom.' '.mb_strtoupper($nom);
}

echo "\n";
echo getFullName('Cétin', 'Hülya');

/**
 * Créer une fonction « askUser() » acceptant deux arguments (nom et prénom) de type string.
 * Cette fonction doit retourner une chaîne de caractères sous la forme :
 * « Bonjour prénom, nom. Connaissez-vous Einstein ? »
 */

function askUser(string $nom, string $prenom) : string
{
    return 'Bonjour '.getFullName($nom, $prenom).', Connaissez vous '.getMC2().' ?';
}

echo "\n";
echo askUser('Cetin', 'Hülya');

?>