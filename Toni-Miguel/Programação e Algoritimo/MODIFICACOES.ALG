Algoritmo "modificacoes"
//Toda variável logica tem, por padrão, o valor "FALSO"//
//REGRA 1: Todo conteúdo entre parênteses será apresentado ao Usuário//
//REGRA 2: Tudo que está entre aspas é texto//
Var

   ligado:logico

Inicio

//modificação estática
//   ligado <- verdadeiro

//modificação dinâmica (depende do usuário)
   escreval("Escolha o estado para a variavel LIGADO: (V/F) e Tecle ENTER")
   leia(ligado)

   se (ligado = verdadeiro) entao
      escreval("Executou a primeira ação")
      ligado <- falso
   senao
      escreval("Executou a segunda ação")
      ligado <- verdadeiro
   fimse

   escreval ("O estado da variavel ligado é:", ligado)


Fimalgoritmo