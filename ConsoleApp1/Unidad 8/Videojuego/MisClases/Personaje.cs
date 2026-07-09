namespace MisClases;


public abstract class Personaje
{
   public string Nombre { get; set; }
   public int Nivel { get; set; }
   public int Vida { get; set; }
   public int VidaMaxima { get; set; }
   public int Ataque { get; set; }
   public int Defensa { get; set; }
   public int CombatesJugados { get; set; }
   public int Victorias { get; set; }
   public int Derrotas { get; set; }
   public int DanoInfligido { get; set; }
   public int DanoRecibido { get; set; }
   public Personaje(string nombre)
   {
       Nombre = nombre;
       Nivel = 1;
   }
   public abstract int Atacar();
   public void RecibirDano(int dano)
   {
       Vida -= dano;
       DanoRecibido += dano;
       if (Vida < 0)
       {
           Vida = 0;
       }
   }
}
