namespace MisClases;

public class Camion : Automovil
{
    public int CapacidadCarga;
    public Camion(string marca, int capacidadCarga, int numeroDePuertas) : base(marca, numeroDePuertas)
    {
        CapacidadCarga = capacidadCarga;
    }
    public void Cargar()
    {
        Console.WriteLine($"El camión puede cargar {CapacidadCarga} toneladas.");
    }
}