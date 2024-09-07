<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario</title>
</head>
<body>
    <h1>Trabalhando com Envio de Informações</h1>
    <p>Este formulario irá enviar informações para algum lugar e com um método
        que será definido como GET ou POST.
    </p>

    <hr>

    <form action="receberDados.php" method="POST">
        <label for="txtNome">Digite o seu nome:</label>
        <input type="text" name="txtNome" id="txtNome" required>

        <label for="txtSenha">Insira sua Senha:</label>
        <input type="password" name="txtSenha" id="txtSenha" required>
        <hr>
        <input type="submit" value="Enviar informação">
    </form>    
    
</body>
</html>