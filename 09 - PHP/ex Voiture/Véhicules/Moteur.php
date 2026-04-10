<?php


/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:53
 */
class Moteur
{

	var $marque;
	var $vitesseMax;

	function Moteur()
	{
	}



	/**
	 * 
	 * @param _vitesseMax
	 * @param _marque
	 */
	function __construct($_vitesseMax, $_marque)
	{
	}

	function getmarque()
	{
		return $this->marque;
	}

	function getvitesseMax()
	{
		return $this->vitesseMax;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setvitesseMax($newVal)
	{
		$this->vitesseMax = $newVal;
	}

	function toString()
	{
	}

}
?>