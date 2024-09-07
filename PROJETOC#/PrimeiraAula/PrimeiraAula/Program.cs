using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade = 0;

            Console.WriteLine("Chegamos ao C#");

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade:");
            try
            {
                idade = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Impossível realizar o cadastro");
            Console.WriteLine(ex.Message);
            }
                Console.WriteLine("Seja bem vindo(a) " + nome + " estamos na aula de C#" + " notei que você tem " + idade.ToString() + " anos");
                Console.WriteLine($"Seja bem vindo(a) {nome} estamos na aula de C# notei que você tem {idade} anos");
        }

    }

}
