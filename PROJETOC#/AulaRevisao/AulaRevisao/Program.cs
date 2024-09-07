using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            //-------------------------------------------------------------------------------------------------

            ArrayList familia = new ArrayList();

            familia.Add("Miguel Santos Pereira");
            familia.Add("Maria das Graças dos Santos Pereira");
            familia.Add("Isabelly Santos Pereira");
            familia.Add("Sergio Pereira");
            familia.Add(3);
            familia.Add(false);

            for (int i=0; i<familia.Count; i++)
            {
                Console.WriteLine(familia[i]);
            }

            //-------------------------------------------------------------------------------------------------

            /*Console.WriteLine(notas[0]);
            Console.WriteLine("A nota escolhida foi: " + notas[0]); //Concatenação
            Console.WriteLine("A soma das notas dão: " + (notas[0] + notas[1] + notas[2]) );

            Console.WriteLine("\n");

            Console.WriteLine($"A nota escolhida foi: {notas[0]}"); //Interpolação
            Console.WriteLine($"A soma das notas dão: {notas[0]+notas[1]+notas[2]}");
            */
            
        }
    }
}
