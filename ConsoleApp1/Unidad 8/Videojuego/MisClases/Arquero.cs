namespace MisClases;

public class Arquero : Personaje
{
    public Arquero(string nombre, int nivel)
        : base(nombre)
    {
        Nivel = nivel;
        VidaMaxima = 120;
        Vida = VidaMaxima;
        Ataque = 25;
        Defensa = 10;
        VidaMaxima += (nivel - 1) * 12;
        Vida = VidaMaxima;
    }
    public override int Atacar()
    {
        Random random = new Random();
        if (random.Next(1, 101) <= 25)
        {
            int danoCritico = Ataque * 2;
            DanoInfligido += danoCritico;
            return danoCritico;
        }
        else
        {
            int dano = Ataque;
            DanoInfligido += dano;
            return dano;
        }
    }
}