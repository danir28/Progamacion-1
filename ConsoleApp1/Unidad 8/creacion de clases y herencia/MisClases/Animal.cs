namespace MisClases;

public abstract class Animal
{
    protected string Nombre;
    public Animal(string nombre)
    {
        Nombre = nombre;
    }
    public abstract void HacerSonido();
}