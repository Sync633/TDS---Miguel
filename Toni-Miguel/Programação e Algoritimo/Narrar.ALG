Algoritmo "semnome"



Var
   // criar vari�veis do tipo inteiro.
   l_atual, tot_carac, l_encontrada, espaco:inteiro   ]
   //criar vari�veis do tipo caractere.
   frase, l_pesq:caracter

Inicio

   //exibir ao usu�rio uma mensagem solicitando uma palavras ou frase.
   escreval("Digite uma palavra ou frase:")
   //receber um dado do usu�rio e atribuir a vari�vel "frase".
   leia(frase)

   //atribuir para vari�vel "tot_carac", o comprimento(em caracteres) da vari�vel "frase".
   tot_carac <- compr(frase)

   //exibir ao usu�rio uma mensagem solicitando qual caracter ele deseja contar.
   escreval("Qual caracter deseja contar na frase/palavra?")
   //receber um dado do usu�rio e atribuir a vari�vel "l_pesq".
   leia(l_pesq)

   //criar um loop para a vari�vel "l_atual" que come�a do 1 e vai at� o valor de "tot_caract", e executar o c�digo dentro do bloco "fa�a".
   para l_atual de 1 at� tot_carac faca
      //exibir ao usu�rio: uma c�pia de uma parte da vari�vel "frase" que inicia-se na posi��o de "l_atual" e termina em 1 caracter, e exibir qual a posi��o do caracter.
      escreval(copia(frase;l_atual;1), " -> caracter numero", l_atual)

      //SE o caracter de (copia(frase;l_atual;1) for igual a letra pesquisada (l_pesq) executar o bloco ent�o.
      se (copia(frase;l_atual;1) = l_pesq) entao
         //atribuir a vari�vel "l_encontrada" um valor de +1.
         l_encontrada <- l_encontrada + 1
      //caso n�o
      senao
         //SE o caracter de copia(frase;l_atual;1) for igual a um espa�o vazio (" ") executar o bloco ent�o.
         se (copia(frase;l_atual;1) = " ") entao
            //atribuir a vari�vel "espaco" um valor de +1.
            espaco <- espaco + 1
         fimse
      fimse
   fimpara

   //exibir ao usu�rio uma mensagem exibindo o total de caracteres da frase.
   escreval("Total de caracteres na palavra/frase: ", tot_Carac)
   //exibir ao usu�rio uma mensagem exibindo o total de espa�os na frase.
   escreval("Total de espacos na palavra/frase: ", espaco)
   //exibir ao usu�rio a letras que foi pesquisada e o total de letras encontradas na pesquisa.
   escreval("Total de letras: ", l_pesq, " foram: ", l_encontrada)

Fimalgoritmo