<?php
require_once ('Moteur.php');

/**
 * @author fchatelot
 * @version 1.0
 * @created 19-nov.-2025 10:20:44
 */
class Voiture
{

	var $leMoteur;
	var $marque;
	var $modele;
	var $poids;
	var $sonMoteur;

	/**
	 * 
	 * @param _marque
	 * @param _modele
	 * @param _poids
	 * @param _maqueMoteur
	 * @param _vitesseMax
	 */
	function __construct($_marque, $_modele, $_poids = 1000, $_maqueMoteur, $_vitesseMax)
	{
	}

	function getleMoteur()
	{
		return $this->leMoteur;
	}

	function getmarque()
	{
		return $this->marque;
	}

	function getmodele()
	{
		return $this->modele;
	}

	function getpoids()
	{
		return $this->poids;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setleMoteur(Moteur  $newVal)
	{
		$this->leMoteur = $newVal;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setpoids(int $newVal)
	{
		$this->poids = $newVal;
	}

	function toString()
	{
	}

	/**
	 * Moteur.vitesseMax - (Voiture.poids x 30%).
	 */
	function vitesseMax()
	{
	}

	
}
?>