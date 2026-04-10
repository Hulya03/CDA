<!DOCTYPE html>
<html lang="fr-FR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php $titre = "foire aux vins"; echo $titre;  ?></title>
    <link rel="stylesheet" href="./assets/css/styleformu.css">
</head>

<body>
    <?php
    // controlleur principal 
    require "./src/dao/Dbconnection.php";
    require "./src/dao/DepartmentRepository.php";
    if (isset($_GET["page"])) {
        $path = $_GET["page"] ?? "home";
    } else {
        $path = "home";
    }



    switch ($path) {
        case 'inscription':
            include "./src/views/inscription.php";
            break;
        case 'home':
            include "./src/views/home.php";
            break;
        default:
            include "./src/views/home.php";
            break;
    }





    ?>
</body>

</html>