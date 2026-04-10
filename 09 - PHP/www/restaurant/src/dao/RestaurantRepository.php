<?php
class RestaurantRepository{
    private ?PDO $dbConnect;
    private int $nbCol;
    private array $tabNameCol=[];

    public function __construct()           //on a besoin d'une connextion globale
    {
        $this->dbConnect=Dbconnexion::getInstance();
        $this->nbCol=0;
    }


    // Les méthodes CRUD

    public function searchAll() : array
    {
        $data= [];
        $rq= "SELECT nom, adresse, prix, commentaire, note, visite FROM restaurants" ;            //requete SQL
        $stmt= $this->dbConnect->query($rq);                                                      //PDO statement
                                                                                                  // si SQL fonction, renvoie un PDO statement
        $data=$stmt->fetchAll();                                                                  // récupere les données par NOM DE COLONNE (configuré dans Dbconnexion car on a choisi FETCH_ASSOC)
        return $data;
    }



    //requete préparée : 

    public function searchById(int $_id) : array|bool     // on accpete 2 types de sorties : du coup si $_id n'existe pas, renvoie 
    {
        $rqSQL="SELECT 
                    nom,
                    adresse,
                    prix, 
                    commentaire,
                    note,
                    visite
                FROM 
                    restaurants
                WHERE id =:ID";                                                          //:ID = marqueur à définir
        $PDOstmt = $this->dbConnect->prepare($rqSQL);
        $PDOstmt->bindValue(":ID", $_id, PDO::PARAM_INT);
        $PDOstmt->execute();                                                            //il nous donne un id, mais ne peut pas l'exploiter pour le moment
        $data=$PDOstmt->fetch();    
        return $data;                                                                    //on obtient un tableau 
    }

    
    // utilisation SOUNDEX = fait la recherche sur phoneme (meme son), trouve malgré erreur d'orthograpge

    public function searchByName(string $_name): bool|array
    {
        $rqSQL="SELECT 
                    id,
                    nom,
                    adresse,
                    prix, 
                    commentaire,
                    note,
                    visite
                FROM 
                    restaurants
                WHERE soundex(nom)=soundex(:nom)";
        $PDOstmt= $this->dbConnect->prepare($rqSQL);
        $PDOstmt->execute([":nom"=>$_name]);

        return $PDOstmt->fetchAll();                          // il peut avoir plusieurs resultats donc on utilise fetchAll
    }

    public function searchByNote(float $_noteLimite): bool|array
    {
        $rq= "call afficherListeNote(:note)";
        $stmt = $this->dbConnect->prepare($rq);
        $stmt->bindValue(":note", $_noteLimite);
        $stmt->execute();

        return $stmt->fetchAll();

    }


    // affichage sans bindValue possible : 

    public function searchByPrice(float $_minPrice, float $_maxPrice) : bool|array
    {
        $stmt= $this->dbConnect->prepare("call afficherListeParPrix(:prixMin, :prixMax);");
        $stmt->execute([":prixMin"=>$_minPrice, ":prixMax"=>$_maxPrice]);

        return $stmt->fetchAll();
    }


    // Version avec Tableau indexé     ->vérifier si ca marche !!

    //  public function searchByPrice(float $_minPrice, float $_maxPrice) : bool|array
    //  {
    //    $stmt= $this->dbConnect->prepare("call afficherListeParPrix(?,?);");
    //    $stmt->execute([1=>$_minPrice, 2=>$_maxPrice]);  
    //   return $stmt->fetchAll();                            
    //  }



    function afficherTableau(array $_data): string
{
    $chaine = "<table class='styled-table'> <thead> <tr>";
    foreach ($_data[0] as $key => $value) {
        $chaine .= "<th>" . $key . "</th>";
    }
    $chaine .= "</tr> </thead> <tbody>";
    foreach ($_data as $ligne) {
        $chaine .= "<tr>";
        foreach ($ligne as $key => $cellule) {
            $chaine .= "<td>" . $cellule . "</td>";
        }
        $chaine .= "</tr>";
    }
    $chaine .= "</tbody> </table>";
    return $chaine;

}



// utilisation du Create du CRUD

public function createRestaurant(string $_nom, string $_adresse, float $_prix, string $_commentaire, float $_note, DateTime $_visite ):bool // bool -> renvoie true s'il renvoie une ligne 
{
    //pour protéger
    $nom=trim($_nom);   
    $adresse=trim($_adresse);
    $prix=floatval($_prix);
    $commentaire=trim($_commentaire);
    $note=floatval($_note);
    $madate=$_visite->format('Y-m-d');
    // ou autre facon : $madate=date_format($visite,'Y-m-d');


    $rq = "INSERT INTO restaurants (nom, adresse, prix, commentaire, note, visite) VALUES (:nom, :adresse, :prix, :commentaire, :note, :visite)"; //on met tous les champs sauf id car il est Auto-Incrémenté
    $PDOstmt= $this->dbConnect->prepare($rq);
    $PDOstmt->bindValue(":nom", $nom, PDO::PARAM_STR);
    $PDOstmt->bindValue(":adresse", $adresse, PDO::PARAM_STR);
    $PDOstmt->bindValue(":prix", $prix);
    $PDOstmt->bindValue(":commentaire", $commentaire , PDO::PARAM_STR);
    $PDOstmt->bindValue(":note", $note);
    $PDOstmt->bindValue(":visite", $madate);

    return $PDOstmt->execute(); 

}




}