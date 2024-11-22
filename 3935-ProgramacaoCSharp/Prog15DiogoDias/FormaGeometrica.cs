// Classe abstrata base
public abstract class FormaGeometrica
{
    // Propriedades para posição
    public double PosicaoX { get; set; }
    public double PosicaoY { get; set; }

    // Métodos abstratos que devem ser implementados pelas subclasses
    public abstract double CalculaArea();
    public abstract double CalculaPerimetro();

    public override string ToString()
    {
        return "Classe Forma Geometrica";
    }
}

// Subclasse Retangulo
public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

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
        return "Classe Forma Retangulo";
    }
}

// Subclasse Quadrado
public class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

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
        return "Classe Forma Quadrado";
    }
}

// Subclasse Circulo
public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

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
        return "Classe Forma Circulo";
    }
}

// Subclasse Triangulo
public class Triangulo : FormaGeometrica
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public override double CalculaArea()
    {
        // Fórmula de Heron
        double s = (Lado1 + Lado2 + Lado3) / 2;
        return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
    }

    public override double CalculaPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }

    public string RetornaTipo()
    {
        if (Lado1 == Lado2 && Lado2 == Lado3)
            return "Equilátero";
        else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3)
            return "Isósceles";
        else
            return "Escaleno";
    }
}