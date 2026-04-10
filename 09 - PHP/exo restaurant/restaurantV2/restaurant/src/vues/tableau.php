<?php
function afficherTableau(array $data): string
{

    $chainesHtml = "<table class='styled-table' ><thead><tr>";
    foreach (array_keys($data[0]) as $colonne) {
        $chainesHtml .= "<th>" . htmlspecialchars($colonne) . "</th>";
    }
    $chainesHtml.= "</tr></thead><tbody>";
    foreach ($data as $ligne) {
        $chainesHtml .= "<tr>";
        foreach ($ligne as $cellule) {
            $chainesHtml .= "<td>" . htmlspecialchars((string)$cellule) . "</td>";
        }
        $chainesHtml .= "</tr>";
    }
    $chainesHtml .= "</tbody></table>";
    return $chainesHtml;
}
