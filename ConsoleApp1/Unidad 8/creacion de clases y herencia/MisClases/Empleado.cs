namespace MisClases;

public class Empleado : Persona
{
    public string Puesto;
    public Empleado(string nombre, int edad, int dni, string puesto)
        :base(nombre, edad, dni)
    {
        Puesto = puesto;
    }
    public void Trabajar()
    {
        Console.WriteLine($"Trabajo de {Puesto}");
    }
}