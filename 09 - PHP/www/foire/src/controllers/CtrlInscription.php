<?php

namespace src\controllers;
use src\dao\CandidateRepository;
use src\dao\DepartmentRepository;

function ctrlInscription() : void
{

$objCandidat = new CandidateRepository();
$objDept = new DepartmentRepository();
$tabData = $objDept->searchAll();

if($_SERVER['REQUEST_METHOD'] === 'POST')
{
    $lastname = trim($_POST['lastname']); 
    $firstname = trim($_POST['firstname']); 
    $email = $_POST['email'];
    $password = $_POST['password'];
    $confirmPassword = $_POST['confirmPassword'];
    $department = $_POST['department'];
    $age = $_POST['age'];

    
    $errors = [];

    if (empty($lastname) || empty($firstname) || empty($email) || empty($password) || empty($confirmPassword) || empty($department) || empty($age))
    {
        $errors[] = "Tous les champs sont obligatoires";
    }else 
    {
        if($password != $confirmPassword)
        {
            $errors[] = "Les mots de passe ne correspondent pas";
        }else
        {
            $test= $objCandidat->insert($lastname, $firstname, $email, $password, $department, $age);
            
            if($test)
            {
                
                echo "insertion candidat réussi";
                header("Location: index.php?action=home");
                exit();
            }
        } 
    }
    var_dump($errors);
} 

require "./src/views/inscription.php";

}
