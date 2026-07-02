namespace MisClases;

public class Automovil : Vehiculo
{
    public int NumeroDePuertas;
    public Automovil(string marca, int puertas) : base(marca)
    {
        NumeroDePuertas = puertas;
    }
    public void Puertas()
    {
        Console.WriteLine($"El automóvil tiene {NumeroDePuertas} puertas.");
    }
}