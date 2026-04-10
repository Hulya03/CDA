<?php 
class Contribuable {

private string $nom;
private float $revenus;
private const TAUX_T0=0.0 ;
private const TAUX_T1=0.11;
private const TAUX_T2=0.3;
private const TAUX_T3=0.41;
private const TAUX_T4=0.45;

public function getNom(): string {
    return $this->nom;
}
public function getRevenus(): float {
    return $this->revenus;
}

public function __construct(string $_nom, float $_revenus) {
    $this->nom = $_nom;
    $this->revenus = $_revenus;
}

public function calculerImpot(): float {
    $montant= 0.0;

    switch ($this->revenus) {
        case $this->revenus<=11497:  
            $montant= $this->revenus * self::TAUX_T0;
            break;
        case $this->revenus<=29315:
             $montant= 11497 * self::TAUX_T0+ ($this->revenus - 11497) * self::TAUX_T1;
             break;

         case $this->revenus<=83823:
              $montant= 1959.98 + ($this->revenus- 29315)*self::TAUX_T2;  
            break;
         case $this->revenus<=180294:   
            $montant =  1959.98 + 16352.4 +( $this->revenus - 83823) *Contribuable::TAUX_T3;
            break;
         case $this->revenus> 180294:
            $montant = 57865.49  + ($this->revenus - 180294)*self::TAUX_T4; 
            break;
        default:
            $montant =0;
            break;
    }
   
    return $montant;
}


}