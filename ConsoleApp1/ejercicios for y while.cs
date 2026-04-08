int codigo = 0;
float precio = 0;
int cantidad = 0;
int CantidadMayor = 0;
int CodigoMayor = 0;
Console.WriteLine("Ingrese un codigo del producto (1-10):");
codigo = int.Parse(Console.ReadLine());
while (0 < codigo && codigo < 11)
{
    Console.WriteLine($"Ingrese el precio del producto {codigo}:");
    precio = float.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese la cantidad del priducto {codigo}:");
    cantidad = int.Parse(Console.ReadLine());
    if (cantidad > CantidadMayor)
    {
        CantidadMayor = cantidad;
        CodigoMayor = codigo;
    }
    Console.WriteLine("Ingrese un codigo del producto (1-10):");
    codigo = int.Parse(Console.ReadLine());
}
Console.WriteLine($"El codigo del producto con mayor cantidad fue: {CodigoMayor}");