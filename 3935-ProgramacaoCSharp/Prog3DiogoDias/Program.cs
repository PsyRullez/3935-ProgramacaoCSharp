using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Escreve um número: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            if (n1> 0)
            {
                Console.WriteLine("\n Numero Negativo\n\n");
            }
            else if (n1< 0) {
                Console.WriteLine("\n Numero Positivo\n\n");
            }
            else
            {
                Console.WriteLine("\n Numero Neutro\n\n");
            };
            Console.WriteLine($" \n O Numero seguinte a {n1} é {++n1}");
            Console.WriteLine($" \n o Número n1 é {n1}");

            Console.WriteLine();
            Console.ReadKey();// para não fechar logo o programa e ver o resultado
        }
    }
}
