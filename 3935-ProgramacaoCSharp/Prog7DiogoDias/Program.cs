/*
 * O programa deve sortear 16 numeros de 0 a 99 para uma matriz de 4x4.
 * O programa depois de sortear os numeros deverá escrever a matriz completa e depois escrever os seguintes valores:
 * [Linha.Coluna]
 * Matriz [2.3]
 * Matriz [0.2]
 * Matriz [2.0]
 * Matriz [2.4] Esta matriz não existe!
 */
using System;

namespace Prog7DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa o gerador de números aleatórios
            Random rand = new Random();

            // Declara a matriz 4x4
            int[,] matriz = new int[4, 4];

            // Preenche a matriz com números aleatórios entre 0 e 99
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = rand.Next(0, 100);
                }
            }

            // Exibe a matriz completa
            Console.WriteLine("Matriz completa (4x4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Exibe os valores específicos das posições solicitadas
            Console.WriteLine($"\nMatriz [2,3]: {matriz[2, 3]}");
            Console.WriteLine($"Matriz [0,2]: {matriz[0, 2]}");
            Console.WriteLine($"Matriz [2,0]: {matriz[2, 0]}");

            //Console.WriteLine($"Matriz [2,4]: {matriz[2, 4]}");
        }
    }
}
