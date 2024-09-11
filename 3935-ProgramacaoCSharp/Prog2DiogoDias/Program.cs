using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Qual o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($" {n1} + {n2} = {n1+n2}");
            Console.ReadLine();
        }
    }
}
