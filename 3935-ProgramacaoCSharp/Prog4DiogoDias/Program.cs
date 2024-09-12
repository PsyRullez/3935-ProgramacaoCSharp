using System;

namespace Prog4DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                // Lê o primeiro número
                Console.WriteLine("Insira o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                // Lê o segundo número
                Console.WriteLine("Insira o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                // Lê a operação
                Console.WriteLine("Insira a operação a ser realizada (+, -, *, /): ");
                string operacao = Console.ReadLine();

                // Realiza a operação com base no input
                switch (operacao)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case "/":
                        // Verifica se o divisor é zero
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }

                // Pergunta se o user deseja continuar
                Console.WriteLine("Deseja realizar outra operação? (s/n)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s")
                {
                    continuar = false;
                }
            }
        }
    }
}
