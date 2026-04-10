<?php 

/* Création de la fonction qui affiche "Hello World" */

function helloWorld() : void
{
    echo "Hello World "; 
}

// Test de la fonction (la fonction affiche directement la fonction)
helloWorld();


/* créer une fonction « hello() » qui accepte un argument de type string et qui retourne « Hello »
suivi de la valeur de l'argument.*/

/**
* Retourne "Hello $name !"
* @param string $name le nom à afficher
*/


function hello(string $name) : string
{
    if(empty($name))
    {
        return "Hello Nobody";           
    }
    else
    {
         return "Hello $name";   
    }
}

// test de la fonction :
// (a fonction n'affiche rien donc utilisation de "echo" qui affichera la valeur retournée par la fonction

echo hello("");

?>