namespace MisClases;

public abstract class Figura
{
    protected string Nombre;
    public Figura(string nombre)
    {
        Nombre = nombre;
    }
    public abstract void CalcularArea();
}