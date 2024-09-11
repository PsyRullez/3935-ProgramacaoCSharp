using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            nome = "Diogo Dias";

            // print program 1
            Console.WriteLine("Programa 1");
            // Helo World
            Console.WriteLine("Hello World!");
            // Esperar por um input
            Console.ReadLine();

            Console.WriteLine("\n Programa 2");
            nome = "Diogo Dias";
            Console.WriteLine("Olá " + nome +"!");
            Console.ReadLine();

            Console.WriteLine("\n Programa 3");
            nome = "Diogo Dias";
            Console.WriteLine($"Como estás {nome}?");
            Console.ReadLine();

            Console.WriteLine("\n Programa 4");
            nome = "Diogo Dias";
            Console.WriteLine($"Estás bem {nome.ToUpper()}!");
            Console.ReadLine();
        }
    }
}
