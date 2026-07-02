namespace MisClases;

public class Gato : Animal
{
    public Gato(string nombre) : base(nombre)
    {
    }
    public override void HacerSonido()
    {
        Console.WriteLine("Miau Miau");
    }
}