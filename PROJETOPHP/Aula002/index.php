<?php

$concessionaria=[
    ["placa"=>'ABC4515', "marca"=>'Audi', "modelo"=>'RS7', "ano"=>2023],
    ["placa"=>'FTD3125', "marca"=>'Koenigsegg', "modelo"=>'Regera', "ano"=>2014],
    ["placa"=>'OWM9627', "marca"=>'BMW', "modelo"=> 'M5 Competition', "ano"=> 2023],
    ["placa"=>'NSI3965', "marca"=>'Bugatti', "modelo"=>'Chiron Super Sport 300+', "ano"=>2019]
];

/*echo"<PRE>";
print_r($concessionaria);
echo"<PRE/>";*/

echo $concessionaria[0]['placa']. "<br>";
echo "<hr>";

//----------------------------------------------------------------------------------------------------------------

echo "Usando o FOR para Loop's <br> <br>";
for ($i=0; $i<count($concessionaria); $i++){
    echo $concessionaria[$i]['marca']. " " . $concessionaria[$i]['modelo'];
    echo "<br>";
};

echo "<hr>";

echo "Usando o FOREACH para Loop's <br> <br>";
foreach ($concessionaria as $carro) {
    echo $carro['marca'] . " " . $carro['modelo']. "<br>";
};

//----------------------------------------------------------------------------------------------------------------

echo "<hr>";
echo "Atividade 01 <br> <br>";

$times = ['Santos', 'São Paulo', 'Palmeiras', 'Corinthians', 'Atlético Paranaense'];

for ($i=0; $i<count($times); $i++){
    echo $times[$i] . "<br>";
};


echo "<hr>";
echo "Atividade 02 <br> <br>";

foreach ($times as $time) {
    echo $time . "<br>";
};


echo "<hr>";
echo "Atividade 03 <br> <br>";

$times = [
    [
        "nome"=>'Santos FC',
        "tecnico"=>'Carille',
        "estado"=>'SP'
    ],
    [
        "nome"=>'Corinthians',
        "tecnico"=>'Ruim demais',
        "estado"=>'SP'
    ],
    [
        "nome"=>'São Paulo',
        "tecnico"=>'Thiago Carpini',
        "estado"=>'SP'
    ] 
];

foreach( $times as $time) {
    echo $time['nome'] .
     " / Tecnico: " . $time['tecnico'] .
     " / Estado: " . $time['estado'] . "<br>";
}

