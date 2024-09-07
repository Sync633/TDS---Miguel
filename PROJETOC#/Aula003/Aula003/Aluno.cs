using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Aluno
    {
        //ATRIBUTOS OU CARACTERISTICAS

        public String nomeAluno;
        public int idadeAluno;
        

        public void exibirDados()
        {
            Console.WriteLine($"Aluno(a): {nomeAluno} / Idade: {idadeAluno} anos. \n ");
        }

    }
}
