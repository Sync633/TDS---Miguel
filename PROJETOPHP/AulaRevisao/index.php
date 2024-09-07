<?php

    //Criar Array

    $animais = ['gato', 'cachorro', 'raposa', 'pantera'];

    
    echo $animais[0]. "<br>";
    echo $animais[1]. "<br>";
    echo $animais[2]. "<br>";
    echo $animais[3]. "<br>";

    
    $animais[] = 'gorila';
    $animais[] = 'puma';
    $animais[] = 'orca';
    $animais[] = 'porco';
    $animais[] = 'macaco';
    $animais[] = 'girrafa';
    $animais[] = 'vaca';
    $animais[] = 'javali';
    $animais[] = 'crocodilo';
    $animais[] = 'jacaré';
    $animais[] = 'coruja';

    echo $animais[4]. "<br>";
    echo $animais[5]. "<br>";
    echo $animais[6]. "<br>";
    echo $animais[7]. "<br>";
    echo $animais[8]. "<br>";
    echo $animais[9]. "<br>";
    echo $animais[10]. "<br>";
    echo $animais[11]. "<br>";
    echo $animais[12]. "<br>";
    echo $animais[13]. "<br>";
    echo $animais[14]. "<br>";


    echo "<hr>";


    echo $animais[11] . "<br>";
    $animais[11] = 'elefante';
    echo $animais[11] . "<br>";


    echo "<hr>";


    echo "Quantos elementos possui o array animais? <br>";
    echo count($animais);

    echo "<hr>";

    //unset($animais[2]);

    array_splice($animais,7,4);

    array_splice($animais,8,2);
    

    /*echo "<pre>";
    print_r($animais);
    echo "</pre>";*/

    //LOOP
    //$i é uma variável de contagem, que é acrescida a cada volta do loop

    // $i = 0 ..... $i < 9 ;  9 é o total de elementos do array $animais

    for($i=1; $i < count($animais); $i+=2){
        echo "O animal " . $i . " é o " . $animais[$i] . "<br>";
    };

    echo "<hr>";

    echo "Quantos elementos possui o array animais agora? <br>";
    echo count($animais);

