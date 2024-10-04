using System;

namespace App14DiogoDias
{
    public class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public Circulo(double posicaoX, double posicaoY, double raio)
            : base(posicaoX, posicaoY)
        {
            this.Raio = raio;
        }

        public override double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalculaPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override string ToString()
        {
            return "Circulo.";
        }
    }
}
