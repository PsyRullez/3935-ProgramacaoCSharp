using System;

namespace App14DiogoDias
{
    public class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public Quadrado(double posicaoX, double posicaoY, double lado)
            : base(posicaoX, posicaoY)
        {
            this.Lado = lado;
        }

        public override double CalculaArea()
        {
            return Lado * Lado;
        }

        public override double CalculaPerimetro()
        {
            return 4 * Lado;
        }
        public override string ToString()
        {
            return "Quadrado.";
        }
    }
}

