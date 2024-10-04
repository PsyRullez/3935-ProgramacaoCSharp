using System;

namespace App14DiogoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Retângulo");
                Console.WriteLine("2 - Quadrado");
                Console.WriteLine("3 - Círculo");
                Console.WriteLine("4 - Triângulo");
                Console.WriteLine("0 - Sair");
                Console.Write("Qual a opção? ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CalcularRetangulo();
                        break;
                    case 2:
                        CalcularQuadrado();
                        break;
                    case 3:
                        CalcularCirculo();
                        break;
                    case 4:
                        CalcularTriangulo();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CalcularRetangulo()
        {
            Console.Write("Digite o comprimento do retângulo: ");
            double comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());


            double area = comprimento * largura;
            double perimetro = 2 * (comprimento + largura);

            Console.WriteLine($"Área do retângulo: {area}");
            Console.WriteLine($"Perímetro do retângulo: {perimetro}");
        }

        static void CalcularQuadrado()
        {


            Console.Write("Digite o lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());
            Quadrado Q1 = new Quadrado(0, 0, lado);

            Console.WriteLine($"Forma: {Q1.ToString()}");
            Console.WriteLine($"Área do quadrado: {Q1.CalculaArea()}");
            Console.WriteLine($"Perímetro do quadrado: {Q1.CalculaPerimetro()}");

        }

        static void CalcularCirculo()
        {
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * raio * raio;
            double perimetro = 2 * Math.PI * raio;

            Console.WriteLine($"Área do círculo: {area}");
            Console.WriteLine($"Perímetro do círculo: {perimetro}");
        }

        static void CalcularTriangulo()
        {
            Console.Write("Digite o lado a do triângulo: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado b do triângulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite o lado c do triângulo: ");
            double c = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(a, b, c);

            Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro do triângulo: {triangulo.CalcularPerimetro()}");
            Console.WriteLine($"Tipo do triângulo: {triangulo.RetornaTipo()}");
        }
    }

    public class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcularArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double CalcularPerimetro()
        {
            return A + B + C;
        }

        public string RetornaTipo()
        {
            if (A == B && B == C)
                return "Equilátero";
            else if (A == B || B == C || A == C)
                return "Isósceles";
            else
                return "Escaleno";
        }
    }
}
