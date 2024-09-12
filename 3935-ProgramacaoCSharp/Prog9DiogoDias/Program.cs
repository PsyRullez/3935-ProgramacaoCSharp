/*
 * Criar o seguinte programa de utilização do Objeto Math:
 * 1. Resultado de 3d elevado à 4d potência; -- Math.Pow()
 * 2. Arredonde o seguinte número do tipo “double”: 17.504605d a uma casa decimal; -- Math.Round()
 * 3. Escreva o valor de PI; -- Math.PI
 * 4. Realize a raiz quadrada do número 55d; -- Math.Sqrt()
 * 5. Retorne o menor valor acima do número 2.3d; -- Math.Ceiling()
 * 6. Retorne o maior valor acima do número 2.3d; -- Math.Floor()
 * 7. Retorne o valor Maior de dois números 5 e 9; -- Math.Max()
 * 8. Retorne o valor Menor dois números 7; e13 -- Math.Min()
 * 9. Crie um programa de leia três números (a, b, c) e calcule as raízes da Fórmula Resolvente
 */
using System;


namespace Prog9DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 elevado à 4 potência: " + Math.Pow(3, 4));
            Console.WriteLine("Arredondar 17.504605 a uma casa decimal: " + Math.Round(17.504605, 1));
            Console.WriteLine("Valor de PI: " + Math.PI);
            Console.WriteLine("Raiz quadrada de 55: " + Math.Sqrt(55));
            Console.WriteLine("Menor valor acima de 2.3: " + Math.Ceiling(2.3));
            Console.WriteLine("Maior valor acima de 2.3: " + Math.Floor(2.3));
            Console.WriteLine("Maior valor entre 5 e 9: " + Math.Max(5, 9));
            Console.WriteLine("Menor valor entre 7 e 13: " + Math.Min(7, 13));

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
