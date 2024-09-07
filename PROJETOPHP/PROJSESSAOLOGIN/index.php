<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Inicial</title>
</head>
<body>
    <h2>Página de Abertura</h2>
    <hr>
    <ul>
        <li><a href="/cadUser/frmCadUser.php">Cadastrar Novo Usuário</a></li>
        
        <?php
            session_start();
            if(isset($_SESSION['email'])) {
        ?>
                <li><a href="/paginaRestrita.php">Página de Acesso Restrito</a></li>
        <?php
            } else {
        ?>
                <li><a href="/login/index.php">Fazer Login</a></li>
        <?php
            }
        ?>
    </ul>
</body>
</html>