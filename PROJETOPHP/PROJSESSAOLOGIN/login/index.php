<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário Login</title>
</head>
<body>
    <h1>Login no Sistema</h1>
    <hr>
    <form action="./recLogin.php" method="POST">
        <input type="email" name="txtEmail" id="txtEmail" placeholder="Digite o Email" required> <br> <br>
        <input type="password" name="txtSenha" id="txtSenha" placeholder="Digite a Senha" required> <br> <br>
        <hr>
        <input type="submit" value="Entrar">
    </form>

    
</body>
</html>