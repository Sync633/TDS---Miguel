<?php

define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'bdsistema');
define('CHARSET', 'utf8');
define('USER', 'root');
define('PASSWORD', '123456');

$opçoes = array(PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8', PDO::ATTR_PERSISTENT => TRUE);
$pdo = new PDO(CONECTOR . ":host=" . HOST . ";port=" . PORT . ";dbname=" . DBNAME . ";charset=" . CHARSET . ";", USER, PASSWORD, $opçoes);

$id = $_GET['id'];

$consulta = "DELETE FROM tblogin WHERE id=:id";
$comando = $pdo->prepare($consulta);
$comando->bindValue(":id", $id, PDO::PARAM_INT);
if($comando->execute()){
    header('location: /index.php');
}

