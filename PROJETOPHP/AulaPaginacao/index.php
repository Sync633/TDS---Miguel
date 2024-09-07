<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Paginação</title>
</head>
<body>
    <h1>Formulário Paginação</h1>
    <hr>

    <form action="paginacao.php" method="GET">
        <label for="txtTotalRegistros">Digite o Total de Registros:</label>
        <input type="number" id="txtTotalRegistros" name="txtTotalRegistros" value="100" />
        <br>
        <label for="txtRegistroPagina">Digite o Número de Registros por Página:</label>
        <input type="number" id="txtRegistroPagina" name="txtRegistroPagina"  value="10"/>

        <hr>

        <input type="submit" value="Gerar Paginação">
    </form>
    
</body>
</html>