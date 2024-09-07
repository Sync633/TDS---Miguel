<?php

define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'prjconexao');
define('CHARSET', 'utf8');
define('USER', 'root');
define('PASSWORD', '123456');

$opcoes = array(
    PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8',
    PDO::ATTR_PERSISTENT => TRUE
);

$pdo = new PDO (
    CONECTOR.
    ":host=" . HOST .
    ";port=". PORT .
    ";dbname=". DBNAME .
    ";charset=". CHARSET . ";",
    USER, PASSWORD, $opcoes);


    //LISTANDO CONTATOS
$consulta = "SELECT * FROM contatos";
$comando = $pdo->prepare($consulta);
$comando->execute();
$contatos = $comando->fetchAll();

?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inicializando Conexões com Banco de Dados</title>
</head>
<body>
    <h1>Conexão com BD - Cadastro de Contatos</h1>
    <hr>
    <h2>Formulário Cadastro</h2>

    <form action="receberDadosCadastro.php" method="POST">
        <input type="text" name="txtNome" id="txtNome" placeholder="Informe o Nome" required/>
        <br><br>
        <input type="submit" value="Cadastrar Agora"/>
    </form>

    <hr>

    <h2>Lista de Contatos Atualizadas</h2>
    <table border="1">
        <tr>
            <td>ID</td>
            <td>NOME</td>
            <td>Ações</td>
        </tr>

        <?php foreach($contatos as $contato) {?>
        <tr>
            <td><?= $contato['id'] ?></td>
            <td><?= $contato['nome'] ?></td>
            <td>
                <a href="receberDadosExcluir.php/?id=<?= $contato['id'] ?>">Excluir</a>
                <a href="formDadosEditar.php/?id=<?= $contato['id'] ?>">Editar</a>
                <a href="#">Detalhar</a>
            </td>
        </tr>
        <?php } ?>
    </table>
</body>
</html>
