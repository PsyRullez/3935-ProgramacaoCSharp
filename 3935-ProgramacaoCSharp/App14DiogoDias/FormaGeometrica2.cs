using System;

namespace App14DiogoDias
{
    public abstract class FormaGeometrica
    {
        public double PosicaoX { get; set; }
        public double PosicaoY { get; set; }

        public FormaGeometrica()
        {
            PosicaoX = 0;
            PosicaoY = 0;
        }

        public FormaGeometrica(double posicaoX, double posicaoY)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }

        public abstract double CalculaArea();
        public abstract double CalculaPerimetro();
    }
}
