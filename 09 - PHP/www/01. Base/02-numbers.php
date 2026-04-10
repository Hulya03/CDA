<?php

// Fonction pour faire une addition

function getSum(int $nb1 , int $nb2)
{
    return $nb1 + $nb2;
}

echo getSum(5,8);
echo "\n";


// Fonction pour faire une difference

function getSub(int $nb1 , int $nb2)
{
    return $nb1 - $nb2;
}

echo getSub(5,8);
echo "\n";
echo getSub(8,5);
echo "\n";


// Fonction pour faire une multiplication

function getMulti(float $nb1, float $nb2)
{
    return $nb1 * $nb2;
}

echo getMulti(5.6,3);
echo "\n";
echo getMulti(5.6,-3.7);
echo "\n";


// Fonction pour faire une division 

function getDiv(int $nb1, int $nb2)
{
if ($nb2 == 0)
{
    echo 0;
}
else
{
    return $nb1 / $nb2;
} 
}


echo round(getDiv(20,3),2);
echo "\n";
echo getDiv(20,0);


?>