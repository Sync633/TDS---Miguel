using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia de objeto
            Cliente cli01 = new Cliente();
            cli01.codigo = 2;
            cli01.nome = "Clóvis";
            cli01.peso = 67.8;

            
            Veiculo vei01 = new Veiculo();
            vei01.setPlaca("vjt5976");
            vei01.setCor("Prata");
            vei01.setAno(2007);


            Console.WriteLine("-------Dados do cli01-------");
            Console.WriteLine($"Código do Cliente: {cli01.codigo}");
            Console.WriteLine($"Nome do Cliente: {cli01.nome}");
            Console.WriteLine($"Peso do Cliente: {cli01.peso}");

            Console.WriteLine("-------Dados do vei01-------");
            Console.WriteLine($"Placa do Veículo: {vei01.getPlaca()}");
            Console.WriteLine($"Cor do Veículo: {vei01.getCor()}");
            Console.WriteLine($"Ano do Veículo: {vei01.getAno()}");
        }
    }
}
