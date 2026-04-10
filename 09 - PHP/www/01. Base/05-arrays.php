<?php


$names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo'];


/**
 * 5.A
 * Créer une fonction « firstItem() » qui accepte un argument de type array. Elle devra retourner le premier élément du tableau. Si 
 * le tableau est vide, la fonction retourne null.
 */

function firstItem(array $names) : string
{
    if(empty($names))
    {
        return "null";
    }
    else
    {
    return $names[0];
    }
}

echo firstItem($names).PHP_EOL;


/**
 * 5.B
 * Créer une fonction « lastItem() » acceptant un argument de type array. Elle devra retourner le dernier élément du tableau. Si le 
 * tableau est vide, il faudra retourner null.
 */

function lastItem(array $names) : string
{
    if($names === [])
    {
        return "null";
    }
    else
    {
    return end($names);
    }
}

echo lastItem($names).PHP_EOL;


/**
 * 5.C
 * Créer une fonction « sortItems() » acceptant un argument de type array. 
 * Cette fonction retourne le tableau trié par ordre décroissant. Si le tableau est vide, il faudra retourner un tableau vide.
 */



function sortItems(array $names) : array
{
    if($names === [])
    {
        return [];
    }
    else
    {
        rsort($names);
        return $names;
    }
}

print_r(sortItems($names));

/* autre façon de montrer le resultat mais pas sous forme de tableau :

foreach ($names as $key => $val)
{
    echo "$key = $val\n";
}
*/


/**
 * 5.D
 * Créer une fonction « stringItems() » acceptant un argument de type array. 
 * Cette fonction retourne une chaine de caractère contenant tous les éléments du tableau triés par ordre croissant et séparés par 
 * une virgule et un espace. Si le tableau est vide, il faudra retourner la valeur « Nothing to display ».
 */

function stringItems(array $names) : string
{
    if ($names === [])
    {
        return "Nothing to display";
    }
    else
    {
        sort($names);
        return implode (",", $names);
    }
}

echo stringItems($names);
?>