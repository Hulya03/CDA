<?php


/**
 * @author fchatelot
 * @version 1.0
 * @created 19-nov.-2025 10:20:44
 */
class Moteur
{

	private string $marque;
	private float $vitesseMax;
	/**
	 * 
	 * @param _vitesseMax
	 * @param _marque
	 */
	function __construct($_vitesseMax, $_marque)
	{
	}

	function toString():string
	{

		$test="";
		return $test;
	}

	function getMarque()
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
	function setvitesseMax(float  $newVal)
	{
		$this->vitesseMax = $newVal;
	}
}
?>