<?php 

include "./Moteur.php";
include "./Voiture.php";
include "./VoitureCourse.php";

$voitureV1 = new Voiture("Renault", "Mégane", "Citroen", 220, 1500);

try {                                                                                   //empêche le programme de planter s'il y a une erreur. 
    $voitureV2 = new VoitureCourse("Renault","Captur","Renault",220,1800);              //du coup, il affichera le message de l'exception et on saura clairement où est l'erreur.
} catch (Exception $e) {
    echo $e->getMessage();
    die();
}

$voitureV2 = new VoitureCourse("Renault","Captur","Renault",220,1800);

echo $voitureV1.'<br>';
echo $voitureV2;


