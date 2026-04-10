<?php


class CandidateRepository{
private ?PDO $dbconnect=null;
private int $nbcol; 

public function __construct()
{
    $this->dbconnect=Dbconnection::getInstance();
    $query="SELECT * FROM candidats";
    $stmt= $this->dbconnect->query($query);
    $this->nbcol=$stmt->rowCount();     
}   
public function insert(string $_lastname,string $_firtsname,string $_mail,string $_pass, int $_department, int $_age, int $_archive_user=0):bool
{     
    $lastname = trim($_lastname);
    $firstname=trim($_firtsname);
    $mail =filter_var($_mail,FILTER_VALIDATE_EMAIL);
    $pass=password_hash(trim($_pass),PASSWORD_ARGON2ID);
    $department=filter_var($_department,FILTER_VALIDATE_INT);
    $age=filter_var($_age,FILTER_VALIDATE_INT);

    $query="INSERT INTO candidats VALUES (id_user,:lastname,:firstname,:mail,:pass, :department, :age,:archive)";
    $stmt= $this->dbconnect->prepare($query);
    return $stmt->execute([
        ':lastname'=>$lastname,
        ':firstname'=>$firstname,
        ':mail'=>$mail,
        ':pass'=>$pass,
        ':department'=>$department,
        ':age'=>$age,
        ':archive'=>$_archive_user
    ]);
}

// public function searchByEmail(string $email):array|false
// {
//     $query="SELECT * FROM candidats WHERE email=:email";
//     $stmt= $this->dbconnect->prepare($query);
//     $stmt->execute([':email'=>$email]);
//     return $stmt->fetch();              



// }

public function verifSign(string $mail,string $pass):array|false
{
    $query="SELECT * FROM candidats WHERE mail_user=:mail_user";
    $stmt= $this->dbconnect->prepare($query);
    $stmt->execute([':mail_user'=>$mail]);
    $user=$stmt->fetch();
    $nligne=$stmt->rowCount();
    if($nligne==1 && password_verify($pass,$user['pass_user'])){
        return $user;
    }
    return false;

}
public function searchAll():array
{
        $query="SELECT lastname_user, firstname_user, mail_user, departement_user, age_user FROM candidats";
        $stmt= $this->dbconnect->prepare($query);
        $stmt->execute();
        return $stmt->fetchAll();
}


public function update(array $data):bool
{
    $query="UPDATE candidates SET username=:username, password=:password, department=:department, age=:age WHERE email=:email";
    $stmt= $this->dbconnect->prepare($query);
    return $stmt->execute([
        ':username'=>$data['username'],
        ':email'=>$data['email'],
        ':password'=>$data['password'],
        ':department'=>$data['department'],
        ':age'=>$data['age']
    ]);
}

}