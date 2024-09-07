Algoritmo "quiz"

Var

   nome:caractere
   resposta:caractere
   iniciar:logico


Inicio

   escreval("Olà!")
   escreval("Digite o seu nome:")
   leia(nome)
   limpatela

   escreval("Seja Bem Vindo, ",nome)
   escreval("")

   escreval("Pronto para começar o seu Quiz? ( V=Verdadeiro ou F=Falso )")
   leia(iniciar)
   limpatela

   se(iniciar = verdadeiro)entao
      escreval("Pergunta 1")
      escreval("")

      escreval("   Qual é a data que celebra a Independência do Brasil")
      escreval("")
      escreval("(a) 12 de Outubro")
      escreval("(b) 7 de Setembro")
      escreval("(c) 25 de Dezembro")
      escreval("(d) 1 de Maio")
      escreval("(e) 1 de Janeiro")

      leia(resposta)
      escreval("")

      timer 400
      timer 0

      se(resposta = "b")entao
         escreval("Parabens!!! Certa Resposta")
      senao
         escreval("Errou, vai estudar rapaz")
      fimse -


      timer 2500
      timer 0


      limpatela

      escreval("Pergunta 2")
      escreval("")

      escreval("   Qual é a data em que se celebra o Dia do Trabalhador no Brasil")
      escreval("")
      escreval("(a) 7 de Setembro")
      escreval("(b) 12 de Outubro")
      escreval("(c) 1 de Maio")
      escreval("(d) 25 de Dezembro")
      escreval("(e) 1 de Janeiro")

      leia(resposta)
      escreval("")

      timer 400
      timer 0

      se(resposta = "c")entao
         escreval("Parabens!!! Certa Resposta")
      senao
         escreval("Errou, vai estudar rapaz")
      fimse


      timer 2500
      timer 0
      
      limpatela
      escreval("Parabens!!! Você completou o QUIZ")

   senao
      escreval("Que pena, volte outra hora para tentar")

   fimse

Fimalgoritmo