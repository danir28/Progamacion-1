namespace MisClases;

public class Mago : Personaje
{
    public Mago(string nombre, int nivel)
        : base(nombre)
    {
        Nivel = nivel;
        VidaMaxima = 100;
        Vida = VidaMaxima;
        Ataque = 50;
        Defensa = 5;
        VidaMaxima += (nivel - 1) * 10;
        Vida = VidaMaxima;
    }
    public override int Atacar()
    {
        int dano = Ataque;
        DanoInfligido += dano;
        return dano;
    }
}