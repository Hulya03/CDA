
<?php

class Pret
{

    // attributs
    private float $capital;
    private float $tauxMensuel;
    private int $nbMois;
    private string $nom; 
   
    // propriétés
    //accesseurs
    public function getCapital(): float
    {
        return $this->capital;
    }
    public function getTauxMensuel(): float
    {

        return $this->tauxMensuel;
    }

    public function getMois(): int
    {
        return $this->nbMois;
    }
   function getNom(): string {
        return $this->nom;
    } 

    //modifieur
  public function setCapital(float $_capital): void {
        $this->capital = $_capital;
    }
  
    function setNom(string $_nom): void {
        $this->nom = $_nom;
    }
    // Constructeur

    public function __construct(string $_nom, float $_montant, float $_tauxAnnuel,int $_nbAnnees)
    {       $this->nom= $_nom;
        $this->capital = $_montant;
        $this->tauxMensuel = $_tauxAnnuel/1200;
        $this->nbMois = $_nbAnnees * 12;
      
    }

// méthode de calcul

    public function calculMensualite(): float
    {
        $Q = (1 - pow((1 + $this->tauxMensuel), -$this->nbMois));
        $mensualite = ($this->capital * $this->tauxMensuel) / $Q;
        return round($mensualite, 2);
    }

    //methode pour affichage
    public function calculMensualite2(): string
    {
        $Q = (1 - pow((1 + $this->tauxMensuel), -$this->nbMois));
        $mensualite = ($this->capital * $this->tauxMensuel) / $Q;
        return number_format($mensualite, 2, ",", " ") . " €";
    }

  //tableau d'amortissement  

public function getTableauAmortissement():array
{
$data=array();
   $partInteret = 0;
    $partAmortissement = 0;
    $mensualite =  $this->calculMensualite();
    $capitalRestant=$this->capital;
for ($i=0; $i < $this->nbMois ; $i++) { 

    if($i>0)
    {   $capitalRestant-=$partAmortissement;
    }
    $partInteret=$capitalRestant*$this->tauxMensuel;
    $partAmortissement=$mensualite-$partInteret;
    array_push($data, ["num_mois"=>$i+1,"partInteret"=>number_format($partInteret, 2, ",", " ") . " €","partAmortissement"=>number_format($partAmortissement, 2, ",", " ") . " €","capital_restant"=>number_format($capitalRestant, 2, ",", " ") . " €","mensualite"=>number_format($mensualite, 2, ",", " ") . " €" ]);
}
return $data;
}

// méthode pour affichage html du tableau d'amortissement
    public function getTableauAmortissementHtml(): string
    {   $tableau= $this->getTableauAmortissement();
        $table='<table class="table table-success table-striped-columns" ><thead><tr>';
        foreach ($tableau[0] as $key=>$value)      {
            $table.='<th>'.$key.'</th>';
        }
        $table.='</tr></thead><tbody>';
    for ($i=0; $i <count($tableau) ; $i++) { 
      
        $ligne=$tableau[$i];
            $table.='<tr>';
       foreach ($ligne as $key => $value) {
                $table.='<td>'.$value.'</td>';
            }
            $table.='</tr>';
        }
       
        $table.='</tbody></table>';
       
        return $table;  
    }


    public function getTableauAmortissementJSON(): string
    {
        $chaineJSON = "[";

        $data = array();
        $partInteret = 0;
        $partAmortissement = 0;
        $mensualite = $this->calculMensualite();
        $capitalRestant = $this->capital;
        for ($i = 0; $i < $this->nbMois; $i++) {


            $partInteret = $capitalRestant * $this->tauxMensuel;
            $partAmortissement = $mensualite - $partInteret;
            if ($i > 0) {
                $capitalRestant -= $partAmortissement;
            }


            Array_push($data,  ["num_mois" => $i + 1, "partInteret" => round($partInteret, 2), "partAmortissement" => round($partAmortissement, 2), "capital_restant" => round($capitalRestant, 2), "mensualite" => round($mensualite, 2)]);
        }

        for ($i = 0; $i < count($data); $i++) {


            if ($i < count($data) - 1) {
                $chaineJSON .= json_encode($data[$i], JSON_PRETTY_PRINT) . ",";
            } else {
                $chaineJSON .= json_encode($data[$i], JSON_PRETTY_PRINT);
            }
        }
        $chaineJSON .= "]";



        return $chaineJSON;
    }
    public function getreportJSON(): void
    {
        $chaineJSON = " [";

        $data = array();
        $partInteret = 0;
        $partAmortissement = 0;
        $mensualite = $this->calculMensualite();
        $capitalRestant = $this->capital;
        for ($i = 0; $i < $this->nbMois; $i++) {


            if ($i > 0) {
                $capitalRestant -= $partAmortissement;
            }
            else


            Array_push($data,  ["num_mois" => $i + 1, "partInteret" => round($partInteret, 2), "partAmortissement" => round($partAmortissement, 2), "capital_restant" => round($capitalRestant, 2), "mensualite" => round($mensualite, 2)]);
        }

        for ($i = 0; $i < count($data); $i++) {


            if ($i < count($data) - 1) {
                $chaineJSON .= json_encode($data[$i], JSON_PRETTY_PRINT) . ",";
            } else {
                $chaineJSON .= json_encode($data[$i],JSON_PRETTY_PRINT);
            }
        }
        $chaineJSON .= "]";


        file_put_contents( "./report/simulationPret.json", $chaineJSON); 
       
    }
}
