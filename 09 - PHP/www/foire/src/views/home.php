<div class="main-content">
    <h2>Liste des Candidats</h2>
    <div class="home-table-container">

<?php                   //page d'accueil

function displayData(array $data) : string
{
    $resultHtml =                                                           //Creation du début du tableau
        "<table>
            <thead>
                <tr>";

    foreach($data[0] as $key => $value)
    {
        $resultHtml .= "<th>" . htmlspecialchars($key) . "</th>";           //enregistrement des clés de la première ligne c'est-à-dire du nom des colonne
                                                                            //htmlspecialchars : au cas ou injection, neutraliser à la sortie
    }

    $resultHtml .= "</tr></thead><tbody>";                                  //fermeture de la 1ere ligne et ouverture du "tbody"

    foreach ($data as $key => $line)
    {
        $resultHtml .= "<tr>";
        foreach ($line as $key => $value)
        {
            $resultHtml .= "<td> " .htmlspecialchars((string)$value)  . "</td>";   //remplissadu tableau ligne par ligne avec les valeurs    
        }
        $resultHtml .= "</tr>";
    }
    $resultHtml .= "</tbody></table>";
    return $resultHtml;

}


echo displayData($dataCandidat);



//tout ce ce qui génère du html, ce sont des views

?>