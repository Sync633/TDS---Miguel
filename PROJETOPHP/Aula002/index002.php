<?php

  $alunos = [
    ["nome"=>"tone", "ra"=>123456],
    ["nome"=>"Jake", "ra"=>11111],
    ["nome"=>"Gabi", "ra"=>254566]
  ];

  echo $alunos[2]['nome'] . " - " . $alunos[2]["ra"];

  echo"<PRE>";
  print_r($alunos);
  echo"</PRE>";