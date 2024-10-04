using System;

namespace App14DiogoDias
{
    public class Retangulo : FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double posicaoX, double posicaoY, double largura, double altura)
            : base(posicaoX, posicaoY)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalculaArea()
        {
            return Largura * Altura;
        }

        public override double CalculaPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override string ToString()
        {
            return "Retangulo.";
        }
    }
}
