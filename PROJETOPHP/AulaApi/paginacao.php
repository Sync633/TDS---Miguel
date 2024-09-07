<?php
    if(isset($_GET['cmbApi'])) {
        $url = $_GET['cmbApi']; //define a api de acesso
        $curl = curl_init();    //inicializa o curl
        curl_setopt($curl, CURLOPT_URL, $url);   //define opções do curl
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);   //define opções do curl
        $response = curl_exec($curl);   //executa a consulta curl
        if(curl_errno($curl)) {     //tratamento de rro
            $error_message = curl_error($curl);
            echo "Erro ao fazer a requisição: $error_message";
        }
        curl_close($curl);  //finaliza a execução curl
        $lista = json_decode($response);    //converte a string para json

        $totalRegistros = count($lista);
        $registroPagina = $_GET['txtRegistroPagina'];

        //AQUI
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
                <p>Registro Número: <?= $i ?> - ID: <?= $lista[$i-1]->id ?> - Município: <?= $lista[$i-1]->nome ?> </p>
        <?php 
            }
        ?>
    </div>

    <?php for($i=1; $i <= $totalPaginas; $i++) { ?>
        <a href=
        "?paginaSelecionada=<?= $i ?>&cmbApi=<?= $url ?>&txtRegistroPagina=<?= $registroPagina ?>">
        <?= $i ?> - </a>
    <?php } ?>
    

    <hr>
    <a href="index.php">Voltar</a>
    
</body>
</html>