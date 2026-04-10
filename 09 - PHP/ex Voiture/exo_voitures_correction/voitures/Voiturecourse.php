<?php
require_once ('Voiture.php');

/**
 * @author fchatelot
 * @version 1.0
 * @created 19-nov.-2025 10:20:48
 */
class Voiturecourse extends Voiture
{



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

	function toString()
	{
	}

	/**
	 * Moteur.vitesseMax - (Voiture.poids x 5%).
	 */
	function vitesseMax()
	{
	}

	

}
?>