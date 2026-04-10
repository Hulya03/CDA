<?php
require "./src/dao/Dbconnexion.php"; 
require "./src/dao/RestaurantRepository.php";

// $ObjDbconnect= Dbconnexion::getInstance();

// var_export($ObjDbconnect);

$objResto= new RestaurantRepository();



//var_export($objResto->searchAll());

//var_export($objResto->searchById(2));

//var_export($objResto->searchByName("jean-yve-shillinguer"));

var_export($objResto->searchByNote(9));