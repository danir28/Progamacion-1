namespace MisClases;

public class Vehiculo
{
    public string Marca;
    public Vehiculo(string marca)
    {
        Marca = marca;
    }
    public void Conducir()
    {
        Console.WriteLine("El vehículo está en movimiento.");
    }
}