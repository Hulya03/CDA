<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php 

    session_start();

    //controleur principal
    require "./src/dao/DbConnection.php"; 
    require "./src/dao/DepartmentRepository.php";
    require "./src/dao/CandidateRepository.php";
    require "./src/controllers/CtrlAccueil.php";
    require "./src/controllers/CtrlInscription.php";
    require "./src/controllers/CtrlLogin.php";
    require "./src/controllers/CtrlComptePerso.php";
    

    //include "./src/views/inscription.php";         // si on inclut ici 

    if(isset ($_GET['page']))                   //si "page" existe  
    {
        $path = $_GET['page'] ?? 'home';        // si y'a 'page', c'est 'page' sinon c'est 'home'
    }
    else 
    {
        $path = 'home';
    }

    switch ($path) {                                //$page doit etre une variable GET. en finction de valeur, on va aller chercher telle ou telle vue/page
        case 'inscription':
            //include "./src/views/inscription.php";   //plus besoin de ce include car c'est le controleur qui va chercher via la méthode ctrlInscription    
            ctrlInscription();
            break;
        case 'home' :
            //include "./src/views/home.php";
            ctrlAccueil();
            break;
        case 'login' : 
            ctrlLogin();
            //include "./src/views/login.php";
            break;
        case 'comptePerso' :
            ctrlComptePerso();
            break;
        default:
            //include "./src/views/home.php";                  // On bascule dans page d'accueil par défaut : 
            ctrlAccueil();
            break;
    }





?>

</body>
</html>