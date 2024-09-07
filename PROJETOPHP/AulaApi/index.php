<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Paginação</title>
</head>
<body>

    <form method="GET" action="paginacao.php">

        <select name="cmbApi" id="cmbApi" required>
            <option value="servicodados.ibge.gov.br/api/v1/localidades/estados">Lista de Estados</option>
            <option value="servicodados.ibge.gov.br/api/v1/localidades/municipios">Lista de Municípios Brasileiros</option>
            <option value="servicodados.ibge.gov.br/api/v1/localidades/estados/35/municipios">Lista de Municípios UF: SP</option>
        </select>
        <input type="number" id="txtRegistroPagina" name="txtRegistroPagina" value="10"/>
        <hr>
        <input type="submit" value="Gerar Paginação">
    </form>
    
</body>
</html>