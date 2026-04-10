<!DOCTYPE html>
<html lang="fr-FR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?php $titre = "Foire aux vins"; echo $titre;  ?></title>
    <link rel="stylesheet" href="./assets/css/styleformu.css">
    <link rel="stylesheet" href="./assets/css/stylelogin.css">
</head>

<body>
    <?php

       session_start();
    // controlleur principal 
    require "./src/dao/Dbconnection.php";
    require "./src/dao/DepartmentRepository.php";
      require "./src/dao/CandidateRepository.php";
      require "./src/controllers/CtrlAccueil.php";
    require "./src/controllers/CtrlInscription.php";
    require "./src/controllers/CtrlLogin.php";
    require "./src/controllers/Ctrlcompte.php";

    if (isset($_GET["page"])) {
        $path = $_GET["page"] ?? "home";
    } else {
        $path = "home";
    }



    switch ($path) {
        case 'inscription':

           ctrlInscription();
     
            break;
        case 'home':
            ctrlAccueil();
     
            break;
         case 'login':
           
           ctrlLogin();
           // include "./src/views/login.php";   
            break;

          case "compteperso":
            ctrlCompte();
            break;
            
        default:
        ctrlAccueil();
       
            break;
    }

    ?>
</body>

</html>