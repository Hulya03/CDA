<?php 

/**
 * 6.A
 * Créer une fonction « getToday() ». Cette fonction doit afficher et retourner la date du jour au format d/m/Y sous forme de 
 * chaine de caractères (exemple : 21/10/2020).
 */

/**
 * On pourrait aussi utiliser la classe DateTimeImmutable :
 * Représentation d'une date et heure. Cette classe se comporte de la manière identique à DateTime
 * à l'exception que de nouveaux objets sont retournés quand des méthodes de modification telle que DateTime::modify() sont appelées.
 * Avantages de DateTimeImmutable
 *  - Sécurité : Évite les modifications accidentelles
 *  - Prévisibilité : L'objet original n'est jamais modifié
 */

function getToday() :string
{
    $today = new DateTime();

    return $today ->format('d/m/Y');
}

echo getToday()."\n";

/**
 * 6.B
 * Créer une fonction « getTimeLeft() » acceptant un argument de type string et qui retourne une chaine de caractère.
 * La valeur de l'argument représente une date au format Y-m-d (ex: 2020-11-23). 
 * La fonction doit vérifier si la date fournie est valide (bon format, date cohérente).
 * Si la date est ultérieure à la date du jour, la fonction retourne la différence en années/mois ou mois/jours (voir exemples).
 * Si la date est égale à la date du jour, la fonction retourne « Aujourd'hui ».
 * Si la date est antérieure à la date du jour, la fonction retourne « Évènement passé ».
 * Exemples :
 * Pour les exemples suivants: DateDuJour = 2020-01-30 (30 Janvier 2020)
 * getTimeLeft ("2019-09-29"); // retourne « Évènement passé »
 * getTimeLeft ("2020-01-30"); // retourne « Aujourd'hui »
 * getTimeLeft ("2020-02-15"); // retourne « Dans 16 jours »
 * getTimeLeft ("2020-05-16"); // retourne « Dans 4 mois et 17 jours »
 * getTimeLeft ("2021-05-30"); // retourne « Dans 1 an et 4 mois »
 * getTimeLeft ("2022-10-17"); // retourne « Dans 2 ans et 9 mois »
 */

function getTimeLeft(string $dateToTestString) : string
{
    // Verification si date valide
    $dateArray = explode('-', $dateToTestString);            // séparation des parties entre "-" et rangement dans un tableau 

    if (count($dateArray) != 3)
    {
        return "Date invalide";
    }

    $year = $dateArray[0];
    $month = $dateArray[1];
    $day = $dateArray[2];

    if (checkdate($year,$month,$day) == false)
    {
        return "Date invalide";
    } 
    
    //créer des objets date : 
        // de la date soit disant d'aujourd'hui
        // de la date à tester qui était en format string 

    $dateToday = new DateTimeImmutable('2020-02-30'); 
    $dateToTest = new DateTimeImmutable($dateToTestString);
    $dateToday->setTime(0,0,0);                                 //on met les heures à zero pour comparer que les dates
    $dateToTest->setTime(0,0,0);

    if ($dateToday == $dateToTest)
    {
        return "Aujourd'hui";
    }

    if ($dateToday > $dateToTest)
    {
        return "Evènement passé";
    }

    // Calcul des différences 
    
    $between = $dateToday->diff($dateToTest);

    $diff_year = $between->y;
    $diff_month = $between->m;
    $diff_day = $between->d;

    if ($diff_year > 0)
    {
        

    }
    
}
        