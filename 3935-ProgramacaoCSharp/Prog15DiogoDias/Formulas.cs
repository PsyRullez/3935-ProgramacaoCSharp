using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog15DiogoDias
{
    internal class Formulas
    {
        // Retângulo
        public double AreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }

        public double PerimetroRetangulo(double largura, double altura)
        {
            return 2 * (largura + altura);
        }

        // Quadrado
        public double AreaQuadrado(double lado)
        {
            return lado * lado;
        }

        public double PerimetroQuadrado(double lado)
        {
            return 4 * lado;
        }

        // Circulo
        public double AreaCirculo(double raio)
        {
            return Math.PI * raio * raio;
        }

        public double PerimetroCirculo(double raio)
        {
            return 2 * Math.PI * raio;
        }

        // Triangulo
        public double AreaTriangulo(double lado1, double lado2, double lado3)
        {
            // Fórmula de Heron
            double s = (lado1 + lado2 + lado3) / 2; // Heron
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        public double PerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public string TipoTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
                return "Equilátero";
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                return "Isósceles";
            else
                return "Escaleno";
        }
    }
}