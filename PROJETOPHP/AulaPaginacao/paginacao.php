<?php

    if(isset($_GET['txtTotalRegistros'])) {
        $totalRegistros = $_GET['txtTotalRegistros'];
        $registroPagina = $_GET['txtRegistroPagina'];

        $totalPaginas = 1;

        if($totalRegistros % $registroPagina == 0) {
            $totalPaginas = $totalRegistros/$registroPagina;
        }else{
            $totalPaginas = ($totalRegistros/$registroPagina) + 1;
        }


        $paginaSelecionada = 1;
        if(isset($_GET['paginaSelecionada'])) {
            $paginaSelecionada = $_GET['paginaSelecionada'];
        }

        $ultimoRegistroPagina = $paginaSelecionada * $registroPagina;
        $primeiroRegistroPagina = $ultimoRegistroPagina - ($registroPagina - 1);

        if($ultimoRegistroPagina > $totalRegistros) {
            $ultimoRegistroPagina = $totalRegistros;
        }

    }else{
        header("location: index.php");
    }

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Paginação Criada</h1>
    <hr>

    <div>
        <h2>Exibindo os Registros da Página: <?= $paginaSelecionada ?> </h2>
        <ul>
            <li>Primeiro Registro da Página: <?= $primeiroRegistroPagina ?></li>
            <li>Último Registro da Página: <?= $ultimoRegistroPagina ?></li>
        </ul>
    </div>

    <hr>

    <div>
        <h3>Lista dos Registros</h3>
        <?php
            for($i=$primeiroRegistroPagina; $i <= $ultimoRegistroPagina; $i++) {
        ?>
                <p>Registro Número: <?= $i ?>;
        <?php 
            }
        ?>
    </div>

    <?php for($i=1; $i <= $totalPaginas; $i++) { ?>
        <a href=
        "?paginaSelecionada=<?= $i ?>
        &txtTotalRegistros=<?= $totalRegistros ?> 
        &txtRegistroPagina=<?= $registroPagina ?>">
        <?= $i ?> - </a>
    <?php } ?>
    

    <hr>
    <a href="index.php">Voltar</a>
    
</body>
</html>