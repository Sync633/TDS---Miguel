Algoritmo "jogo_de_cartas"



Var

   numero1:inteiro
   numero2:inteiro

Inicio
   escreval("Pegue uma das cartas númericas")

   escreval(" Jogador 1, Digite o valor de sua carta:")
   leia(numero1)
   escreval(" Jogador 2, Digite o valor de sua carta:")
   leia(numero2)

   se(numero1>numero2)então
      escreval("")
      escreval("Vitória!!!")
      escreval("O Jogador 1 venceu")
   senão
      se(numero1=numero2)então
         escreval("")
         escreval("Empate")
      senão
         escreval("")
         escreval("Vitória!!!")
         escreval("O Jogador 2 venceu")
      fimse
   fimse



Fimalgoritmo
