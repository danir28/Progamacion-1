namespace Clases;

public class Radio
{
    public string Marca { get; set; }
    public void EmitirSonido()
    {
        Console.WriteLine("Bip, bip: Cambio y fuera");
    }
}