<?php
session_start();

if(isset($_SESSION['email'])) {
?>

    <!DOCTYPE html>
    <html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Página Restrita</title>
    </head>
    <body>
        <h1>Página de Acesso Restrito</h1>
        <hr>
        <h3>Para você acessar essa página só existe 2 possibilidades:</h3>
        <ol>
            <li>Você fez o login corretamente com Usuário e Senha.</li>
            <li>Seu sistema tem uma falha de segurança.</li>
        </ol>

        <hr>
        <a href="./login/logout.php">Logout do Sistema</a>
    </body>
    </html>

<?php
} else {
    header('location: ./login/index.php');
}
?>