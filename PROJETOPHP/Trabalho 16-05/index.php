<?php

define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'bdsistema');
define('CHARSET', 'utf8');
define('USER', 'root');
define('PASSWORD', '123456');

$opçoes = array(PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8', PDO::ATTR_PERSISTENT => TRUE);
$pdo = new PDO(CONECTOR. ":host=" . HOST . ";port=" . PORT . ";dbname=" . DBNAME . ";charset=" . CHARSET . ";", USER, PASSWORD, $opçoes);

$consulta = "SELECT id, email, senha FROM tblogin";
$comando = $pdo->prepare($consulta);
$comando->execute();
$usuarios = $comando->fetchAll();


?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sitema Usuários</title>
</head>

<body>
    <h1>Cadastro de Usuários</h1>

    <hr>
    
    <h2>Cadastrar Novo Usuário</h2>
    <form action="receberDadosCadastro.php" method="POST">
        <label for="txtEmail">EMAIL:</label>
        <input type="email" name="txtEmail" id="txtEmail" placeholder="Email">
        <br><br>
        <label for="txtSenha">SENHA:</label>
        <input type="password" name="txtSenha" id="txtSenha" placeholder="Senha">
        <br><br>
        <input type="submit" value="Cadastrar">
    </form>
    
    <hr>

    <h2>Lista de Usuários Atualizada</h2>
    <table border='1'>

        <tr>
            <td>ID</td>
            <td>EMAIL</td>
            <td>SENHA</td>
            <td>Ações</td>
        </tr>
        <?php foreach ($usuarios as $usuario){ ?>
        <tr>
            <td><?= $usuario['id']?></td>
            <td><?= $usuario['email']?></td>
            <td><?= $usuario['senha']?></td>
            <td>
                <a href="receberDadosExcluir.php/?id=<?= $usuario['id']?>">EXCLUIR</a>
                <a href="#">EDITAR</a>
                <a href="#">Detalhar</a>
            </td>
        </tr>
        <?php } ?>

    </table>
    
</body>
</html>