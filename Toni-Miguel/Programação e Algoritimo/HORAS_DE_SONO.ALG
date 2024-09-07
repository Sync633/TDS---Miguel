Algoritmo "horas_de_sono"

Var

   idade:inteiro

Inicio

   escreval("Calcular suas horas de sono recomendadas")
   escreval("Digite sua idade:")
   leia(idade)


   se(idade <=0) então
      escreval("Tu é Burro em")
   senão

      se(idade <=2) então
         escreval("11 a 14 horas")
      senão

         se(idade <=5) então
            escreval("10 a 13 horas")
         senão

            se(idade <=12) então
               escreval("9 a 12 horas")
            senão

               se(idade <=18) então
                  escreval("8 a 10 horas")
               senão

                  se(idade <=60) então
                     escreval("7 ou mais horas")
                  senão

                     se(idade <=64) então
                        escreval("7 a 9 horas")
                     senão
                        escreval("7 a 8 horas")

                     fimse
                  fimse
               fimse
            fimse
         fimse
      fimse
   fimse


Fimalgoritmo
