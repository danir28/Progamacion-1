namespace Clases;

public class Motocicleta : Vehiculo
{
    public int CapacidadPasajeros { get; set; }
    public Motocicleta(string patente, int kilometraje, int capacidadPasajeros)
        : base(patente, kilometraje)
    {
        CapacidadPasajeros = capacidadPasajeros;
    }
}