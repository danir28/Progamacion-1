namespace Clases;

public abstract class Vehiculo
{
    public string Patente { get; set; }
    public int Kilometraje { get; set; }
    public List<Viaje> Viajes { get; set; }

    public Vehiculo(string patente, int kilometros)
    {
        Patente = patente;
        Kilometraje = kilometros;
        Viajes = new List<Viaje>();
    }

    public void AgregarViaje(Viaje NuevoViaje)
    {
        Viajes.Add(NuevoViaje);
        Kilometraje += NuevoViaje.Distancia;
    }
    public int CalcularDistancia()
    {
        int total = 0;
        foreach (Viaje viaje in Viajes)
        {
            total += viaje.Distancia;
        }
        return total;
    }
}