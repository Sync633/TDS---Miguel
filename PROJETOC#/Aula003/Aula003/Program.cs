using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Aluno primeiroAluno = new Aluno();
            primeiroAluno.nomeAluno = "Isabelly Santos Pereira";
            primeiroAluno.idadeAluno = 8;
            primeiroAluno.exibirDados();


            Aluno segundoAluno = new Aluno();
            segundoAluno.nomeAluno = "Simons Ghost Riley";
            segundoAluno.idadeAluno = 34;
            segundoAluno.exibirDados();


            Aluno terceiroAluno = new Aluno();
            terceiroAluno.nomeAluno = "Alan Ferreira Pereira";
            terceiroAluno.idadeAluno = 18;
            terceiroAluno.exibirDados();


            Aluno quartoAluno = new Aluno();
            quartoAluno.nomeAluno = "Vladimir Ernesto";
            quartoAluno.idadeAluno = 16;
            quartoAluno.exibirDados();

            //------------------------------------------------------------------------------------------------------------------//

            Turma primeiraTurma = new Turma();
            primeiraTurma.codigoTurma = 1;
            primeiraTurma.serieTurma = "1° A";
            primeiraTurma.exibirDados();

            Turma segundaTurma = new Turma();
            segundaTurma.codigoTurma = 2;
            segundaTurma.serieTurma = "1° B";
            segundaTurma.exibirDados();

            /*Console.WriteLine("Nome: " + primeiroAluno.nomeAluno + " / Idade:" + primeiroAluno.idadeAluno);
            Console.WriteLine($"Nome: {segundoAluno.nomeAluno} / Idade: {segundoAluno.idadeAluno}");
            Console.WriteLine($"Nome: {terceiroAluno.nomeAluno} / Idade: {terceiroAluno.idadeAluno}");*/

        }
    }
}
