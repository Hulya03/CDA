<?php
require_once ('Moteur.php');

/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:51
 */
class Voiture
{

	var $marque;
	var $modele;
	var $poids_kg;
	var $sonMoteur;

	function Voiture()
	{
	}



	/**
	 * 
	 * @param _marque
	 * @param _modele
	 * @param _poids
	 * @param _marqueMoteur
	 * @param _vitesseMaxMoteur
	 */
	function __construct($_marque, $_modele, $_poids = 1000, $_marqueMoteur, $_vitesseMaxMoteur)
	{
	}

	function toString()
	{
	}

	function getmodele()
	{
		return $this->modele;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setmodele($newVal)
	{
		$this->modele = $newVal;
	}

	function getpoids_kg()
	{
		return $this->poids_kg;
	}

	function getmarque()
	{
		return $this->marque;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setpoids_kg($newVal)
	{
		$this->poids_kg = $newVal;
	}

	/**
	 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 30%)
	 */
	function calculVitesseMax()
	{
	}

}
?>