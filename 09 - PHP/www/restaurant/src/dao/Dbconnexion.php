<?php

// design pattern : Singleton

class Dbconnexion {
    private static ?PDO $connexion=null;             // Objet majeur pour accédéer à la BDD     // attribut satic car utilisation de méthode static
    private static $host;                            // c'est le serveur dans laquelle se trouve la BDD
    private static $base;                            // nom base
    private static $user;
    private static $pass;
    private static $port;

    private function __construct()              // privatisation du constructeur, il ne peut pas 
    {

    }

    private static function setConfig()
    {
        $config = require __DIR__.'/Config.php';

        self::$host=$config['host'];
        self::$base= $config['base'];
        self::$user= $config['user'];
        self::$pass= $config['pass'];
        self::$port= $config['port']??3306;   //si port non renseigné, mettre 3306 (coelescent)
    }

    public static function getInstance():PDO  //renvoie objet PDO s'il existe, si non elle l'instancie et l'envoie
    {
        if (self::$connexion == null)
        {
            self::setConfig();                 // elle renseigne tous mes attibuts

            try {
                self::$connexion= new PDO("mysql:host=".self::$host.";dbname=".self::$base."; port = ".self::$port."; charset = utf-8",  // 1er argument obligatoire = chaine DSN : choix du sgbd...
                                      self::$user,                                                                                  // 2eme argument obl
                                      self::$pass,                                                                                  // 3eme argument obl.
                                      [PDO::ATTR_DEFAULT_FETCH_MODE=>PDO::FETCH_ASSOC]                            
            );
            } catch (Exception $e) {
                die("connexion database échouée".$e->getMessage());
            }
   
        }
        return self::$connexion;
    }

}