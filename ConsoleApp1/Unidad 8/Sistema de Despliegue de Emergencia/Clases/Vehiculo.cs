namespace Clases;

public abstract class Vehiculo
{
    public string Matricula { get; set; }
    public string Estado { get; set; }
    public Radio RadioInstalada { get; set; }
    public Vehiculo(string matricula, string estado = "disponible")
    {
        Matricula = matricula;
        Estado = estado;
    }
    public abstract string EjecutarProtocolo();
    public void InstalarRadio(Radio radio)
    {
        this.RadioInstalada = radio;
    }
}
