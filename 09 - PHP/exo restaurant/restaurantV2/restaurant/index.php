<!DOCTYPE html>
<html lang="fr-FR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>gestion listes des critiques de restaurants</title>
    <link rel="stylesheet" href="assets/css/style.css">
    
</head>
<body>
    <h1>Liste des critiques de restaurants </h1><br>

    <input type="button" value="creer une critique" id="btnResto" > 
<?php



require "./src/dao/Dbconnexion.php"; 
require "./src/dao/RestaurantRepository.php";
require "./src/vues/tableau.php";
// $ObjDbconnect= Dbconnexion::getInstance();
// var_export($ObjDbconnect);
//var_export($objResto->searchAll());
//var_export($objResto->searchById(2));
//var_export($objResto->searchByName("jean-yve-shillinguer"));

//var_export($objResto->searchByNote(9));
$objResto= new RestaurantRepository();
echo afficherTableau($objResto->searchAll());


//var_export( $objResto->infotable());


?>

    
</body>
<script>
    const monbtn=document.querySelector("#btnResto");
    monbtn.addEventListener("click", function() {
        window.location.href='./formuCreate.php';
    } 
    )
</script>

</html>

