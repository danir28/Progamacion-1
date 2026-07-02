namespace MisClases;

public class LibroDigital : Libro
{
    public int PesoEnMB;
    public string Formato;
    public LibroDigital(string titulo, string autor, int paginas, int pesoEnMB, string formato) 
    : base(titulo, autor, paginas)
    {
        PesoEnMB = pesoEnMB;
        Formato = formato;
    }
}