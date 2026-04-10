<?php

use LDAP\Result;

require_once ('Voiture.php');

/**
 * @author HCetin
 * @version 1.0
 * @created 19-nov.-2025 10:20:54
 */
class VoitureCourse extends Voiture  // Pour héritage : utilisation de extends
{

/**
 * 
 * @param _marque
 * @param _modele
 * @param _poids
 * @param _marqueMoteur
 * @param _vitesseMaxMoteur
 */

function __construct($_marque, $_modele, $_marqueMoteur, $_vitesseMaxMoteur, $_poids_kg = 1000)
	{
		if($_marque == $_marqueMoteur)
		{
			parent::__construct($_marque, $_modele, $_marqueMoteur, $_vitesseMaxMoteur , $_poids_kg);
		}
		else
		{
			throw new Exception("Attention ! La voiture et le moteur doivent être de la même marque");
		} 

	}

function __toString() : string
	{
		$result = "Voiture de course = ".parent::__toString();      // La méthode __toString, herite du parent, et on ajour juste une chaine de caractère devant
		return $result;
	}

/**
 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 0.5%)
 */
function calculVitesseMax() : int 
	{
		$vitesseMaxCalcul = $this->sonMoteur->getvitesseMax() - ($this->poids_kg * 0.005);
		return $vitesseMaxCalcul;
	}

}
?>