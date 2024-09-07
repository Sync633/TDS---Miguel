Algoritmo "Escolha_Tabuada"

Var

   multi:inteiro
   tabuada:inteiro
   repetir:logico
   quanti:inteiro

Inicio

   repetir <- verdadeiro

   enquanto (repetir=verdadeiro) faça

      escreval("Qual tabuada você deseja criar?")
      leia(tabuada)

      escreval("--------------------------------------------------------------")

      escreval(tabuada," x 1")
      escreval(tabuada," x 2")
      escreval(tabuada," x 3")
      escreval(tabuada," x ...")
       escreval(tabuada," x ?")
      
      escreval("")
      escreval("A tabuada deverá ir até qual número?")
      leia(quanti)

      escreval("Aqui está:")

      timer 1000
      timer 0

      escreval("")

      para multi de 1 até quanti faça

         escreval(tabuada," x",multi," =", tabuada*multi)

      fimpara

      escreval("")
      escreval("Deseja Criar outra tabuada? (Verdadeiro/Falso)")
      leia(repetir)

      limpatela

   fimenquanto

Fimalgoritmo