<?php 

require "./src/dao/Dbconnexion.php";
require "./src/dao/RestaurantRepository.php";
require "./src/vues/tableau.php";


//testing :

//$ObjDbconnect= Dbconnexion::getInstance();          //on aura tjrs une seule connexion à la fois

//var_dump($ObjDbconnect);



$objResto = new RestaurantRepository();

//var_dump($objResto->searchAll());                     // permet de récup les ligne en tableau

//var_export($objResto->searchAll());                   // meme chose que var_dump avec moins de détails


//var_export($objResto->searchById(3));

// var_export($objResto->searchByName("jan ive chilinger"));

//var_export($objResto->searchByNote(9.5));

//var_export($objResto->searchByPrice(20,50));

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="./assets/css/style.css" rel="stylesheet">
</head>
<body>
    <h1>Liste des restaurants</h1>

    <input type="button" value="creer une critique" id="btnResto">     <!--permet de basculer à la page du formulaire pour ajouter critique-->
    
    <?php 
    
    echo $objResto->afficherTableau($objResto->searchAll());

    ?>
</body>

<!--pour renvoyer à la page d'ajout de restau -->
<script>
    const monbtn=document.querySelector("#btnResto");
    monbtn.addEventListener("clik", function()
    {
    window.location.href='./formuCreate.php';
    })
</script>
</html>