/*
 * Criar o seguinte programa de utilização do Objeto String:
 * Declare duas variáveis string (x , y) à sua escolha e utilize as seguintes propriedades: 
 * 1. Primeiro caractere da primeira variável “x”: Substring(0, 1)
 * 2. Último caractere da variável “y”: Substring( y.Length - 1, 1))
 * 3. Todos menos o primeiro caracter da variável “x”: Substring(1))
 * 4. O terceiro elemento “x”: Substring(3, 1) ou seja 4º caracter
 * 5. Os três primeiros elementos da variável “y”: Substring(0, 3))
 * 6. Os três últimos elementos de “y”: Substring( y.Length - 3, 3))R

 */
using System;

namespace Prog11DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Frase x das Strings";
            string y = "Outra frase para ser usada";

            // Operações com strings
            Console.WriteLine("Primeiro caractere da primeira variável 'x': " + x.Substring(0, 1));
            Console.WriteLine("Último caractere da variável 'y': " + y.Substring(y.Length - 1, 1));
            Console.WriteLine("Todos menos o primeiro caractere da variável 'x': " + x.Substring(1));
            Console.WriteLine("O quarto elemento 'x': " + x.Substring(3, 1));
            Console.WriteLine("Os três primeiros elementos da variável 'y': " + y.Substring(0, 3));
            Console.WriteLine("Os três últimos elementos de 'y': " + y.Substring(y.Length - 3, 3));

            // Adição de manipulação de data e hora
            DateTime agora = DateTime.Now;

            // 1. Apresente a Data por extenso
            Console.WriteLine("Data por extenso: " + agora.ToString("D"));

            // 2. Apresente a Data e a Hora
            Console.WriteLine("Data e Hora: " + agora.ToString("F"));

            // 3. Apresente o dia da semana em português
            string diaDaSemana = agora.DayOfWeek.ToString();
            string diaDaSemanaEmPortugues = diaDaSemana switch
            {
                "Sunday" => "Domingo",
                "Monday" => "Segunda-feira",
                "Tuesday" => "Terça-feira",
                "Wednesday" => "Quarta-feira",
                "Thursday" => "Quinta-feira",
                "Friday" => "Sexta-feira",
                "Saturday" => "Sábado",
                _ => diaDaSemana
            };
            Console.WriteLine("Dia da semana: " + diaDaSemanaEmPortugues);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

