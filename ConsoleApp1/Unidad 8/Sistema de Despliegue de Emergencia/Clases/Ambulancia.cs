namespace Clases;

public class Ambulancia : Vehiculo
{
    public double CantidadKits { get; private set; }
    public int CantidadPacientes { get; private set; }
    public List<Paciente> Pacientes { get; private set; }
    public Ambulancia(string matricula, int cantidadKits)
        : base(matricula)
    {
        CantidadKits = cantidadKits;
    }
    public override string EjecutarProtocolo()
    {
        return "Ejecutando protocolo de ambulancia...";
    }
    public void AgregarPaciente(Paciente paciente)
    {
        
    }
}