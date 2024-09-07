Algoritmo "semnome"



Var
   // criar variáveis do tipo inteiro.
   l_atual, tot_carac, l_encontrada, espaco:inteiro   ]
   //criar variáveis do tipo caractere.
   frase, l_pesq:caracter

Inicio

   //exibir ao usuário uma mensagem solicitando uma palavras ou frase.
   escreval("Digite uma palavra ou frase:")
   //receber um dado do usuário e atribuir a variável "frase".
   leia(frase)

   //atribuir para variável "tot_carac", o comprimento(em caracteres) da variável "frase".
   tot_carac <- compr(frase)

   //exibir ao usuário uma mensagem solicitando qual caracter ele deseja contar.
   escreval("Qual caracter deseja contar na frase/palavra?")
   //receber um dado do usuário e atribuir a variável "l_pesq".
   leia(l_pesq)

   //criar um loop para a variável "l_atual" que começa do 1 e vai até o valor de "tot_caract", e executar o código dentro do bloco "faça".
   para l_atual de 1 até tot_carac faca
      //exibir ao usuário: uma cópia de uma parte da variável "frase" que inicia-se na posição de "l_atual" e termina em 1 caracter, e exibir qual a posição do caracter.
      escreval(copia(frase;l_atual;1), " -> caracter numero", l_atual)

      //SE o caracter de (copia(frase;l_atual;1) for igual a letra pesquisada (l_pesq) executar o bloco então.
      se (copia(frase;l_atual;1) = l_pesq) entao
         //atribuir a variável "l_encontrada" um valor de +1.
         l_encontrada <- l_encontrada + 1
      //caso não
      senao
         //SE o caracter de copia(frase;l_atual;1) for igual a um espaço vazio (" ") executar o bloco então.
         se (copia(frase;l_atual;1) = " ") entao
            //atribuir a variável "espaco" um valor de +1.
            espaco <- espaco + 1
         fimse
      fimse
   fimpara

   //exibir ao usuário uma mensagem exibindo o total de caracteres da frase.
   escreval("Total de caracteres na palavra/frase: ", tot_Carac)
   //exibir ao usuário uma mensagem exibindo o total de espaços na frase.
   escreval("Total de espacos na palavra/frase: ", espaco)
   //exibir ao usuário a letras que foi pesquisada e o total de letras encontradas na pesquisa.
   escreval("Total de letras: ", l_pesq, " foram: ", l_encontrada)

Fimalgoritmo