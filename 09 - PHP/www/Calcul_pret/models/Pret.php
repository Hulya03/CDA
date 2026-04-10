<?php 

class Pret {

    // Attributs
    private string $nom;
    private float $capital;
    private float $taux;
    private int $nbMoisRemb;

    public function __construct(string $_nom, float $_capital, float $_tauxAnnuel, int $_nbAnneeRemb)
    {
        $this->nom = $_nom;
        $this->capital = $_capital;
        $this->taux = $_tauxAnnuel/12*100;
        $this->nbMoisRemb = $_nbAnneeRemb*12;
    }

    function calculMensualite() : float
    {
        $tauxMensuel = $this->taux / 12;
        $nbMoisRemb = $this->_nbAnneeRemb * 12 ;
        $q = (1- pow((1+$tauxMensuel),(-$nbMoisRemb)));
        $mensualite = ($this->capital * $tauxMensuel) / $q;
        return $mensualite;
    }

}


