<?php
require_once ('Voiture.php');

/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:54
 */
class voitureCourse extends Voiture
{

	function voitureCourse()
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

	/**
	 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 30%)
	 */
	function calculVitesseMax()
	{
	}

}
?>