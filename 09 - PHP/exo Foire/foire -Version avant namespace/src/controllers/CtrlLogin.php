<?php 

// méthode verif sign / verifie que utilisateur et mdp présent et que les deux sont liés dans la table . Puis utiliser password_verifiy

function ctrlLogin() : void
{
    $objCandidat = new CandidateRepository();

    $errors = [];
// var_dump($_POST);
    if (isset($_POST["email"]) && isset($_POST["password"]))
    {
        $email = trim($_POST['email']);
        $password = $_POST['password'];

        if(empty($email) || empty($password))
        {
            $errors[] = "Tous les champs sont obligatoire.";
        }else 
        {$errors[] ="test action";

            $user= $objCandidat->verifSign($email, $password);

            if ($user !== false){
                echo "Connexion réussie";
                $_SESSION['user_id'] = $user['id_user'];
                $_SESSION['nom'] = $user['lastname_user'];
                $_SESSION['prenom'] = $user['firstname_user'];
                var_dump($user);
                  header("Location:./index.php?page=comptePerso");
              exit();
            }
            
        }    
        
        
    }else{
                $errors[] = "Email  ou mot de passe incorrect.";
         }
        
    var_dump($errors);
    require "./src/views/login.php";

}