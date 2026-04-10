<?php

function afficherTableau(array $_data): string
{
    $chaine = "<table class='styled-table'> <thead> <tr>";
    foreach ($_data[0] as $key => $value) {
        $chaine .= "<th>" . $key . "</th>";
    }
    $chaine .= "</tr> </thead> <tbody>";
    foreach ($_data as $ligne) {
        $chaine .= "<tr>";
        foreach ($ligne as $key => $cellule) {
            $chaine .= "<td>" . $cellule . "</td>";
        }
        $chaine .= "</tr>";
    }
    $chaine .= "</tbody> </table>";
    return $chaine;

}