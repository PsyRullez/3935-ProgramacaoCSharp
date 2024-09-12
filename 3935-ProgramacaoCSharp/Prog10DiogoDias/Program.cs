/*
 * Crie um programa que mostre os seguintes arrays's: (usando um foreach)
 * int[] vector1 = { 2, 4, 6, 8, 10 }
 * double[] vector2 = { 20.2D, 12.34D, 1.23D, 3.45D, 10.17D };
 * string[] vector3 = {"Isto ", "é mesmo ", "muito ", "longo... \n"};
 * char[,] matriz1 = { { 'a', 'b', 'c' }, { 'x', 'y', 'z' } };
 * 
 * 1. Listar um vector de inteiros;
 * 2. Listar um vector de doubles;
 * 3. Listar um vector de strings;
 * 4. Listar um array bidimensional de caracteres.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog10DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = { 2, 4, 6, 8, 10 };
            double[] vector2 = { 20.2D, 12.34D, 1.23D, 3.45D, 10.17D };
            string[] vector3 = { "Isto ", "é mesmo ", "muito ", "longo... \n" };
            char[,] matriz1 = { { 'a', 'b', 'c' }, { 'x', 'y', 'z' } };

            Console.WriteLine("Vector de inteiros:");
            foreach (int i in vector1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nVector de doubles:");
            foreach (double d in vector2)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("\nVector de strings:");
            foreach (string s in vector3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nArray bidimensional de caracteres:");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPressione uma tecla para sair");
            Console.ReadKey();
        }
    }
}
