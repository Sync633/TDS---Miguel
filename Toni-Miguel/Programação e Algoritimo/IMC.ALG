Algoritmo "imc"

Var

   peso:real
   altura:real
   imc:real

Inicio

   escreval("CALCULO DO IMC (Indice de Massa Corporal)")
   escreval("")

   escreval("Digite o seu peso. (KG)")
   leia(peso)

   escreval("Digite a sua altura. (Cm ou Metros)")
   leia(altura)


   imc <- (peso/altura^2)

   escreval("")
   escreval("Seu IMC �:", imc)

   se(imc < 18.5)entao
      escreval("Seu peso est� Baixo")
   senao

      se(imc <= 24.99)entao
         escreval("Seu peso est� Normal")
      senao

         se(imc <= 29.99)entao
            escreval("Voc� est� com Sobrepeso")
         senao
            escreval("Voc� est� com Obesidade")

         fimse
      fimse
   fimse




Fimalgoritmo
