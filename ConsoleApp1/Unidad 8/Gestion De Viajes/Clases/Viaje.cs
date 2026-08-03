namespace Clases;

public class Viaje
{
    public int Distancia { get; set; }
    public int CargaTransportada { get; set; }
    public DateTime Fecha { get; set; }
    public Viaje(int distancia, int cargaTransportada, DateTime fecha)
    {
        Distancia = distancia;
        CargaTransportada = cargaTransportada;
        Fecha = fecha;
    }
}