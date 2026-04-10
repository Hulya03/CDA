<?php 

class Contribuable {

    // Déclaration des propriétés
    private string $nom; 
    private ?float $revenu;                                     // ? avant le type : variable peut ne pas être renseignée (attention : non possible pour cet exemple)
    private const TAUX1 = 0.09;                                 // Definition de la constante : nom en MAJUSCULE
    private const TAUX2 = 0.14;


    // Constructeur de la classe Contribuable 

    public function __construct(string $nom, float $revenu){
        $this->nom = $nom;
        $this->revenu = $revenu;
    }

    // Décalaration de la fonction CalculImpot()

    public function CalculImpot():string {
        if ($this->revenu < 15000)
        {
            $impotTotal= $this->revenu * self::TAUX1;                 // utilisation de la constante qui est definie dans la classe d'où utilisation de "self::"
        }
        else 
        {
            $impotANeufPourcent = 15000 * self::TAUX1;
            $impotAQuatorzePourcent = ($this->revenu - 15000) * self::TAUX2;
            $impotTotal = $impotANeufPourcent + $impotAQuatorzePourcent;
            
        }
        return round($impotTotal,2)." €";
    }
}



