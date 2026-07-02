namespace MisClases;

public class Persona
{
    public string Nombre;
    public int Edad;
    public int DNI;

    public Persona(string nombre, int edad, int dni)
    {
        Nombre = nombre;
        Edad = edad;
        DNI = dni;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre}");
    }
}
