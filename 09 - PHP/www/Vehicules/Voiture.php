<?php
require_once ('Moteur.php');

/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:51
 */
class Voiture
{

protected string $marque;
protected string $modele;
protected int $poids_kg;
protected Moteur $sonMoteur;


/**
 * 
 * @param _marque
 * @param _modele
 * @param _poids
 * @param _marqueMoteur
 * @param _vitesseMaxMoteur
 */
function __construct($_marque, $_modele, $_marqueMoteur, $_vitesseMaxMoteur , $_poids_kg = 1000)            // s'il y a une valeur par défaut, on peut la mettre ici, MAIS en dernier 
	{
		$this->marque = $_marque;
		$this->modele = $_modele;
		$this->poids_kg = $_poids_kg;
		$this->sonMoteur = new Moteur($_marqueMoteur, $_vitesseMaxMoteur);
	}

function __toString() : string            // méthode "__toString" magique, elle affiche le contenu, sans devoir écrire "->toString()
	{
		$result = "Voiture [ marque = ". $this->marque. ", modele = ". $this->modele. ", poids_kg = ". $this->poids_kg. ", sonMoteur [ ". $this->sonMoteur. "]<br> mais la voiture a pour vitesse max : ".$this->calculVitesseMax()." ]";
		return $result;
	}


	function getmodele() : string
	{
		return $this->modele;
	}

	function getmarque() : string
	{
		return $this->marque;
	}

	function getpoids_kg() : int 
	{
		return $this->poids_kg;
	}	

	function getsonMoteur() : Moteur
	{
		return $this->sonMoteur;
	}


	/**
	 * 
	 * @param newVal
	 */
	function setmodele($newVal) : void
	{
		$this->modele = $newVal;
	}


	/**
	 * 
	 * @param newVal
	 */
	function setpoids_kg($newVal) : void
	{
		$this->poids_kg = $newVal;
	}

	/**
	 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 3%)
	 */
	function calculVitesseMax() : int
	{
		$vitesseMaxCalcul = $this->sonMoteur->getvitesseMax() - ($this->poids_kg * 0.03);
		return $vitesseMaxCalcul;
	}

}
?>