namespace MisClases;

public class Combate
{
    public Personaje Personaje1 {get; private set;}
    public Personaje Personaje2 {get; private set;}
    public Personaje? Ganador;
    public int CantidadTurnos { get; private set; }
    public Combate(Personaje p1, Personaje p2)
    {
        Personaje1 = p1;
        Personaje2 = p2;
        CantidadTurnos = 0;
    }
    public void IniciarCombate()
    {
        Personaje1.Vida = Personaje1.VidaMaxima;
        Personaje2.Vida = Personaje2.VidaMaxima;
        CantidadTurnos = 0;
        while (Personaje1.Vida > 0 && Personaje2.Vida > 0)
        {
            CantidadTurnos++;
            int dano1 = Personaje1.Atacar();
            Personaje2.RecibirDano(dano1);
            if (Personaje2.Vida <= 0)
            {
                Ganador = Personaje1;
                break;
            }
            int dano2 = Personaje2.Atacar();
            Personaje1.RecibirDano(dano2);
            if (Personaje1.Vida <= 0)
            {
                Ganador = Personaje2;
                break;
            }
        }
        Personaje1.CombatesJugados++;
        Personaje2.CombatesJugados++;
        if (Ganador == Personaje1)
        {
            Personaje1.Victorias++;
            Personaje2.Derrotas++;
        }
        else
        {
            Personaje2.Victorias++;
            Personaje1.Derrotas++;
        }
    }
}