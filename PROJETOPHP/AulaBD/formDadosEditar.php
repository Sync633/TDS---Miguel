<?php
if(isset($_GET['id'])) {
    
    $id = $_GET['id'];

} else {
    header('location: /index.php');
}

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editando o Registro</title>
</head>
<body>
    
    <h2>Formulário Edição Cadastro</h2>
    <hr>
    <br>
    <form action="/receberDadosEditar.php/?id=<?= $id ?>" method="POST">
            <label for="txtNome">NOME:</label>
            <input type="text" name="txtNome" id="txtNome" placeholder="Informe o Nome" required/>
            <br><br>
            <input type="submit" value="Salvar Alterações"/>
        </form>

</body>
</html>
