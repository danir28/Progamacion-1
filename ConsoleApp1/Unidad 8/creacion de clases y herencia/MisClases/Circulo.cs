namespace MisClases;

public class Circulo : Figura
{
    private double Radio;
    public Circulo(string nombre, double radio) : base(nombre)
    {
        Radio = radio;
    }
    public override void CalcularArea()
    {
        double area = Math.PI * Math.Pow(Radio, 2);
        Console.WriteLine($"El área del círculo {Nombre} es: {area}");
    }
}