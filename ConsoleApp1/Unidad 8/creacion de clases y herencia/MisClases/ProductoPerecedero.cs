namespace MisClases;

public class ProductoPerecedero : Producto
{
    public DateTime FechaCaducidad { get; set; }
    public ProductoPerecedero(string nombre, int precio, DateTime fechaCaducidad)
        : base(nombre, precio)
    {
        FechaCaducidad = fechaCaducidad;
    }
    public bool EstaVencido()
    {
        return DateTime.Today >= FechaCaducidad;
    }
}