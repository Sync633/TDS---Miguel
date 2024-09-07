using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Turma
    {

        public int codigoTurma;
        public String serieTurma;

        public void exibirDados()
        {
            Console.WriteLine($"O cógido da turma é: {codigoTurma} e a série é: {serieTurma}");
        }

    }
}
