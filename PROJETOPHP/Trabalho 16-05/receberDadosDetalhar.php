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

$senha = $_GET['senha'];

$consulta = "SELECT :senha FROM tblogin";
$comando = $pdo->prepare($consulta);
$comando->bindValue(":senha", $senha, PDO::PARAM_INT);
$comando->execute();


echo $comando;