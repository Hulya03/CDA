<?php

function ctrlAccueil()                          // controleur dans accueil : role = afficher liste de candidat
{
    $objCandidat = new CandidateRepository();

    $dataCandidat = $objCandidat->searchAll();   //récupéraion de la liste des candidats 
                                                 // c'est un tableau de tableau

    // var_dump($dataCandidat);                     //affiche aussi tableau de tableau

    include './src/views/home.php';

}