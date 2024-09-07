Algoritmo "Tabuada_1ao10"

Var

   tabuada:inteiro
   multi:inteiro
   quantiI:inteiro
   quantiF:inteiro



Inicio

   escreval("As taduadas deverão inciar em?")
   leia(quantiI)
   escreval("Até qual número as tabuadas irão?")
   leia(quantiF)

   escreval("")

   se (quantiI < quantiF) entao

      para tabuada de quantiI até quantiF passo 1 faça
         escreval("-----------------------------------------------")
         escreval("Tabela do:", tabuada)
         escreval("")

         para multi de 1 até 10 passo 1 faça
            escreval(tabuada," x", multi, " =", tabuada*multi)

         fimpara

      fimpara

   senao

      para tabuada de quantiI até quantiF passo -1 faça
         escreval("-----------------------------------------------")
         escreval("Tabela do:", tabuada)
         escreval("")

         para multi de 1 até 10 passo 1 faça
            escreval(tabuada," x", multi, " =", tabuada*multi)

         fimpara

      fimpara

   fimse



Fimalgoritmo