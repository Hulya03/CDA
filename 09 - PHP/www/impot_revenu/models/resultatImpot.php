<?php 

// utilisiation de la classe Contribuable 
include "./Contribuable.php";


//instanciation
$hulya = new Contribuable('Hülya',16000);


//affichage en utilisant l'objet d'où "objet->"
echo $hulya->CalculImpot();


?>