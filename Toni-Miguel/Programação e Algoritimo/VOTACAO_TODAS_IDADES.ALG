Algoritmo "votacao_todas_idades"



Var

   idade:inteiro

Inicio

   escreval("Digite sua idade")
   leia(idade)

   se (idade < 16)entao
      escreval("Voto negado")
   senao

      se (idade <=17) entao
         escreval("Voto permitido, não obrigatorio")
      senão

         se (idade <=70) entao
            escreval("Voto Obrigatório")
         senão
            escreval ("Voto Facultativo")
         fimse
      fimse
   fimse



Fimalgoritmo
