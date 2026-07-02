namespace MisClases;

public class Estudiante : Persona
{
    public string Legajo;
    public Estudiante(string nombre, int edad, int dni, string legajo) 
        : base(nombre, edad, dni)
    {
        Legajo = legajo;
    }
    public void Estudiar()
    {
        Console.WriteLine($"El estudiante {Nombre} está estudiando");
    }
}