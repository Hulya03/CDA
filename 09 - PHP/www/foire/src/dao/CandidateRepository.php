<?php 

namespace src\dao;
use \PDO;

class CandidateRepository
{
    private ?PDO $dbConnect=null;
    private int $nbCol;
    private array $tabColName = [];

    public function __construct()
    {
        $this->dbConnect=DbConnection::getInstance();
    }

    public function searchAll(): array 
    {
        $data = [];
        $query = 
            "SELECT 
                lastname_user,
                firstname_user,
                mail_user,
                departement_user,
                age_user
            FROM
                candidats";
        $stmt= $this->dbConnect->query($query);
        $data = $stmt->fetchAll();
        return $data;
    }

    public function insert(string $_lastname_user, string $_firstname_user, string $_mail_user, string $_pass_user, int $_departement_user, int $_age, int $_archive_user=0) : bool
    {
        $lastname_user = trim($_lastname_user);
        $firstname_user = trim($_firstname_user);
        $mail_user = filter_var($_mail_user, FILTER_VALIDATE_EMAIL);                //verification du format email
        $pass_user = password_hash(trim($_pass_user), PASSWORD_ARGON2ID);           //pour mettre un mot de passe encrypté 
                                                                                    // le hash prend le mot de passe en clair et affiche une sortie aléatoire à chaque fois, 
                                                                                      //car elle prend en compte dans ses paramètre LE TEMPS à laquelle il est crée
        $departement_user = filter_var($_departement_user, FILTER_VALIDATE_INT);
        $age = filter_var($_age, FILTER_VALIDATE_INT);

        $query = 
            "INSERT INTO 
                candidats 
            VALUES 
                (
                id_user,                                             /*on a joute le nom en value donc il sait qu'il va devoire auto-incrémenter*/
                :lastname_user,                                     /*On peu tles nommer comme on veut, pas obligé de mettre comme pour les variables */
                :firstname_user,
                :mail_user,
                :pass_user,
                :departement_user,
                :age,
                :archive_user)";
        $PDOstmt = $this->dbConnect->prepare($query);
        $PDOstmt->bindValue(":lastname_user", $lastname_user, PDO::PARAM_STR);
        $PDOstmt->bindValue(":firstname_user", $firstname_user, PDO::PARAM_STR);
        $PDOstmt->bindValue(":mail_user", $mail_user, PDO::PARAM_STR);
        $PDOstmt->bindValue(":pass_user", $pass_user, PDO::PARAM_STR);
        $PDOstmt->bindValue(":departement_user", $departement_user, PDO::PARAM_INT);
        $PDOstmt->bindValue(":age", $age, PDO::PARAM_INT);
        $PDOstmt->bindValue(":archive_user", $_archive_user, PDO::PARAM_INT);
        return $PDOstmt->execute();

        /* autre facon 
        return $stmt->execute([                                         
                ':lastname_user'=>$lastname_user,                                     
                ':firstname_user'=>$firstname_user,
                ':mail_user'=>$mail_user,
                ':pass_user'=>$pass_user,
                ':departement_user'=>$departement_user,
                ':age'=>$age    
        ]);
        */
    }

    public function verifSign(string $mail,string $pass):array|false
    {
        $query="SELECT * FROM candidats WHERE mail_user=:mail_user";
        $stmt= $this->dbConnect->prepare($query);
        $stmt->execute([':mail_user'=>$mail]);
        $user=$stmt->fetch();
        $nligne=$stmt->rowCount();
        if($nligne==1 && password_verify($pass,$user['pass_user'])){
        return $user;
    }
    return false;
    }
}

?>