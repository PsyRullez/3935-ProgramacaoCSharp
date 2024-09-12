/*
 * Crie um programa para sortear 10 numeros inteiros entre 1 e 100 e guardar em um vetor.
 * Depois o programa deve listar os 10 numeros separando-os por um traço.
 * De seguida deve ordenar o vetor por ordem crescente e listar os numeros na consola.
 * Também deve listar o maior e o menor numero do vetor.
 * OBS: Estrutura FOR;
 * OBS2: Deve perguntar ao user se quer repetir a operação.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numeros = new int[10];
            string resposta = "s";

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    numeros[i] = rnd.Next(1, 101);
                }

                Console.WriteLine("Numeros sorteados: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(numeros[i] + " - ");
                }

                Array.Sort(numeros);
                Console.WriteLine("\nNumeros ordenados: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(numeros[i] + " - ");
                }

                Console.WriteLine("\nMaior numero: " + numeros[9]);
                Console.WriteLine("Menor numero: " + numeros[0]);

                Console.WriteLine("\nDeseja repetir a operação? (s/n)");
                resposta = Console.ReadLine();
            } while (resposta == "s");
        }
    }
}
