/*
 * Crie o código para ler a nota do 1º teste e a nota do 2º teste de um aluno.
 * Depois deverá calcular a nota final que é o valor da média arredondado a um inteiro.
 * Caso a nota final seja entre 0 a 9 deverá escrever "Insuficiente";
 * Caso a nota final seja entre 10 a 13 deverá escrever "Suficiente";
 * Caso a nota final seja entre 14 a 17 deverá escrever "Bom";
 * Caso a nota final seja entre 18 a 20 deverá escrever "Muito Bom";
 * Obs: O programa deve calcular a nota e perguntar ao user se quer fazer um novo calculo.
 * Exeção: "Erro na média"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog5DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
        bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Insira a nota do 1º teste:");
                int nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a nota do 2º teste:");
                int nota2 = int.Parse(Console.ReadLine());
                int media = (nota1 + nota2) / 2;
                if (media >= 0 && media <= 9)
                {
                    Console.WriteLine("Insuficiente");
                }
                else if (media >= 10 && media <= 13)
                {
                    Console.WriteLine("Suficiente");
                }
                else if (media >= 14 && media <= 17)
                {
                    Console.WriteLine("Bom");
                }
                else if (media >= 18 && media <= 20)
                {
                    Console.WriteLine("Muito Bom");
                }
                else
                {
                    Console.WriteLine("Erro na média");
                }
                Console.WriteLine("Deseja fazer um novo calculo? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "n")
                {
                    continuar = false;
                }
            }
        }
    }
}
