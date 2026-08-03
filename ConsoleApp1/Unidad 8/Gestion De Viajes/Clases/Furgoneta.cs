namespace Clases;

public class Furgoneta : Vehiculo
{
    public int CapacidadPasajeros { get; set; }
    public Furgoneta(string patente, int kilometraje, int capacidadPasajeros)
        : base(patente, kilometraje)
    {
        CapacidadPasajeros = capacidadPasajeros;
    }
}