<?php


/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:53
 */
class Moteur
{

	private string $marque;
	private int $vitesseMax;

	/**
	 * 
	 * @param _vitesseMax
	 * @param _marque
	 */
	function __construct( string $_marque, int $_vitesseMax)
	{
		$this->marque = $_marque;
		$this->vitesseMax = $_vitesseMax;
	}


public function toString():string
	{
		$result = "Moteur [ marque : ". $this->marque. ", vitesseMax :".$this->vitesseMax." km/h]";
		return $result;
	} 
public function __toString()
{
	$result = "Moteur [ marque : ". $this->marque. ", vitesseMax :".$this->vitesseMax." km/h]";
		return $result;
}
	

	function getmarque() : string
	{
		return $this->marque;
	}


	function getvitesseMax() : int
	{
		return $this->vitesseMax;
	}

	/**
	 * 
	 * @param newVal
	 */
	function setvitesseMax(int $newVal)  : void
	{
		$this->vitesseMax = $newVal;
	}

}
?>