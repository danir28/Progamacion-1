namespace Clases;

public class Camion : Vehiculo
{
    public int CapacidadCarga { get; set; }

    public Camion(string patente, int kilometraje, int capacidadCarga)
        : base(patente, kilometraje)
    {
        CapacidadCarga = capacidadCarga;
    }
    public int CalcularCargaMaxima()
    {
        return CapacidadCarga;
    } 
}