namespace Clases;

public class CamionBombero : Vehiculo
{
    public int Tanque { get; private set; }
    public CamionBombero(string matricula, int tanque)
        : base(matricula)
    {
        Tanque = tanque;
    }
    public override string EjecutarProtocolo()
    {
        if (Tanque < 1000)
        {
            return "Rechazado. El tanque de agua esta bajo, recargue el tanque";
        }
        else
        {
            Tanque -= 1000;
            return "Ejecutando protocolo, activando mangueras y apagando el fuego";
        }
    }
    public string RecargarAgua()
    {

        if (Tanque < 5000)
        {
            Tanque = 5000;
            return "El tanque de agua ha sido recargado a su capacidad máxima.";
        }
        else
        {
            return "El tanque de agua ya está lleno.";
        }
    }
}