<?php

function ctrlAccueil():void
{
$objCandidat= new CandidateRepository();

$dataCandidat=$objCandidat->searchAll();
//var_dump($dataCandidat);

include "./src/views/home.php";
} 