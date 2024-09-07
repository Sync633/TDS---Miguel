<?php

$cardapio = [
    ['X-TUDO', 'Y-BURGER JACU', 'MC-JACs'],
    ['Batata Frita','Bananinha Fritas','Macaxeira']
];

foreach ($cardapio as $opcao) {
    for ($i=0;$i<count($opcao); $i++) {
        echo $opcao[$i] . '<br>';
    }
};

foreach ($cardapio as $categorias) {
    foreach( $categorias as $item ) {
        echo $item .'<br>';
    }
};




/*echo'<PRE>';
print_r($cardapio);
echo'</PRE>';*/

