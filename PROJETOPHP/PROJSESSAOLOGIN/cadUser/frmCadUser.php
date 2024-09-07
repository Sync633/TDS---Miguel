<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro de Usuário</title>
</head>
<body>
    <h1>CADASTRO DE USUÀRIOS</h1>
    <hr>
    <form action="./recCadUser.php" method="post">
        <input type="text" name="txtNome" id="txtNome" required placeholder="Nome do Usuário">
        <input type="email" name="txtEmail" id="txtEmail" required placeholder="Email@email.com">
        <input type="password" name="txtSenha" id="txtSenha" required placeholder="Senha do Usuário">
        <hr>
        <input type="submit" value="Cadastrar Usuário">
    </form>

    <h2>Lista de Usuários Cadastrados</h2>
    <?php
        require_once('../conexao.php');
        $sql = "SELECT id, nome, senha FROM usuarios";
        $comando = $conexao->prepare($sql);
        $comando->execute();
        $usuarios = $comando->fetchAll();
        foreach($usuarios as $usuario) {
    ?>    
            <li><?= $usuario['id']?> - <?= $usuario['nome'] ?> - <?= $usuario['senha'] ?></li>
    <?php
        }
    ?>
</body>
</html>