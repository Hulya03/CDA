<?php


class CandidateRepository{
private ?PDO $dbconnect=null;
private int $nbcol; 

public function __construct()
{
    $this->dbconnect=Dbconnection::getInstance();
    $query="SELECT * FROM candidates";
    $stmt= $this->dbconnect->query($query);
    $this->nbcol=$stmt->rowCount();     
}   
public function insert(array $data):bool
{
    $query="INSERT INTO candidates (username,email,password,department,age) VALUES (:username,:email,:password,:department,:age)";
    $stmt= $this->dbconnect->prepare($query);
    return $stmt->execute([
        ':username'=>$data['username'],
        ':email'=>$data['email'],
        ':password'=>$data['password'],
        ':department'=>$data['department'],
        ':age'=>$data['age']
    ]);
}

public function searchByEmail(string $email):array|false
{
    $query="SELECT * FROM candidates WHERE email=:email";
    $stmt= $this->dbconnect->prepare($query);
    $stmt->execute([':email'=>$email]);
    return $stmt->fetch();              



}
public function searchAll():array
{
        $query="SELECT * FROM candidates";
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