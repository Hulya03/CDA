<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php 
    //controleur principal
    require "./src/dao/DbConnection.php"; 
    require "./src/dao/DepartmentRepository.php";

    //include "./src/views/inscription.php";         // si on inclut ici 



    switch ($_GET["page"]) {                                //$page doit etre une variable GET. en finction de valeur, on va aller chercher telle ou telle vue/page
        case 'inscription':
            include "./src/views/inscription.php";     
            break;
        
        default:
            include "./src/views/home.php";                  // On bascule dans page d'accueil par défaut : 
            break;
    }





?>

</body>
</html>