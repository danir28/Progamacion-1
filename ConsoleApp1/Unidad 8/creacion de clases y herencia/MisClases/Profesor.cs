namespace  MisClases;

public class Profesor : Persona
{
    public string Materia;
    public Profesor(string nombre, int edad, int dni, string materia)
        : base(nombre, edad, dni)
    {
        Materia = materia;
    }
    public void Enseñar()
    {
        Console.WriteLine($"El profesor {Nombre} está enseñando la materia {Materia}");
    }
}