namespace MisClases;


public class Guerrero : Personaje
{
   public Guerrero(string nombre, int nivel)
       : base(nombre)
   {
       Nivel = nivel;
       VidaMaxima = 150;
       Vida = VidaMaxima;
       Ataque = 30;
       Defensa = 15;
       VidaMaxima += (nivel - 1) * 15;
        Vida = VidaMaxima;
   }
   public override int Atacar()
   {
       int dano = Ataque;
       DanoInfligido += dano;
       return dano;
   }
}
