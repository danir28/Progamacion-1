namespace MisClases;

public class Producto
{
    public string Nombre {get; set;}
    public int Precio {get; set;}
    public Producto(string nombre, int precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}