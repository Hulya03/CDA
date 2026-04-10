<?php 

/**
 * 4.A 
 * Créer une fonction « isMajor() » acceptant un argument de type int. Elle devra retourner un booléen.
 * Si l’âge est supérieur ou égal à 18, elle doit retourner true. Sinon elle doit retourner false.
 */

function isMajor(int $age) : bool
{
if ($age < 18)
{
    return false;
}
else
{
    return true;
}
}

var_dump(isMajor(5));

//var_dump : affiche les informations de la variable


/**
 * 4.B
 * Créer une fonction « getRetired() » acceptant un argument de type int. Elle devra retourner un string.
 * Cette fonction permet de calculer le nombre d’années restant avant la retraite ou le nombre d’années depuis la retraite.
 * Pour cet exercice, l’âge de la retraite est fixé à 60 ans.
 */


function getRetired(int $age) : string 
{
    
    if ($age <0)
    {
        return "Vous n'êtes pas encore né";
    } 
    else if ($age<60)
    {
        return "il vous reste ". 60-$age . " ans avant la retraite.";    
    }
    else if ($age == 60)
    {
        return "Vous êtes à la retraite cette année";
    }
    else 
    {
        return "Vous êtes à la retraite depuis " . $age-60 . " ans";
    }
}

echo getRetired(-2).PHP_EOL;

/**
 * 4.C
 * Créer une fonction « getMax() » acceptant 3 arguments de type float.
 * Cette fonction doit retourner la valeur du plus grand des 3 nombres. Limitez le résultat à 3 décimales
 * Si au moins 2 des valeurs fournies sont égales la fonction retourne 0
 */


function getMax (float $nb1, float $nb2, float $nb3) : float
{
    if ($nb1 == $nb2 || $nb1 == $nb3 || $nb2 == $nb3)
    {
        return 0;
    }
    else 
    {
        return max($nb1, $nb2, $nb3);
    }
}

echo getMax(72,-5,72).PHP_EOL;


/**
 * 4.D
 * Créez une fonction « capitalCity() » qui accepte un argument de type string (le pays dont on cherche la capitale).
 * Elle devra retourner le nom de la capitale des pays suivants :
 * France => Paris
 * Allemagne => Berlin
 * Italie => Rome
 * Maroc => Rabat
 * Espagne => Madrid
 * Portugal => Lisbonne
 * Angleterre => Londres
 * Si le pays ne fait pas partie de la liste ci-dessus, la fonction retourne la valeur « Capitale inconnue ».
 * Note : Utilisez la structure SWITCH pour faire cet exercice.
 */

function capitalCity(string $pays) : string
{
    switch($pays)
    {
        case "France":
            return "Paris";
            break;
        case "Allemagne":
            return "Berlin";
            break;
        case "Italie":
            return "Rome";
            break;
        case "Maroc":
            return "Rabat";
            break;
        case "Espagne":
            return "Madrid";
            break;
        case "Portugal":
            return "Lisbonne";
            break;
        case "Angleterre":
            return "Londres";
            break;
        default :
            return "Capitale inconnue";
            break;
    }
}

echo capitalCity("Turquie").PHP_EOL;

?>