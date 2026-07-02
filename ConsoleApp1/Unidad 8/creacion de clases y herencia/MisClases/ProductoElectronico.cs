namespace MisClases;

public class ProductoElectronico : Producto
{
    public int Voltaje {get; set;}
    public bool TieneGarantia {get; set;}
    public ProductoElectronico(string nombre, int precio, int voltaje, bool tieneGarantia)
        :base(nombre, precio) 
    {
        Voltaje = voltaje;
        TieneGarantia = tieneGarantia;
    }
}