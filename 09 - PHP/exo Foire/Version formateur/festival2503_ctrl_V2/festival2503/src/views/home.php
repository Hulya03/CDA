<?php
function displayData($data):string 
{
  $chainesHtml = "<table class='styled-table' ><thead><tr>";
    foreach ($data[0] as $key=>$value) 
     {
        $chainesHtml .= "<th>" . htmlspecialchars($key) . "</th>";
      
    }
    $chainesHtml .= "</tr></thead><tbody>";
    foreach ($data as $ligne) {
      $chainesHtml .= "<tr>";
      foreach ($ligne as $key => $value) {
       
          $chainesHtml .= "<td>" . htmlspecialchars($value) . "</td>";
        
      }
      $chainesHtml .= "</tr>";
    }
    $chainesHtml .= "</tbody></table>";

   
   
    return $chainesHtml;
 }

echo displayData($dataCandidat);