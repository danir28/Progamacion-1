/*
//Ejercicio 1 y Ejercicio 2
int suma = 0;
int cantidad = 0;
Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());
while (numero > 0)
{
    suma += numero;
    cantidad++;
    Console.WriteLine("Ingrese un numero:");
    numero = int.Parse(Console.ReadLine());
}
float promedio = suma / (float)cantidad;
Console.WriteLine($"La suma de los numeros ingresados es: {suma} y su promedio es: {promedio}");

//Ejericio 3
int cantidad = 0;
Console.WriteLine("ingrese un nombre (vacio para terminar):");
string nombre = Console.ReadLine();
while (nombre != "")
{
    cantidad++;
    Console.WriteLine("ingrese otro nombre (vacio para terminar):");
    nombre = Console.ReadLine();
}
Console.WriteLine($"La cantidad de personas ingresadas es: {cantidad}");

//Ejericio 4
float CostoUnitario = 0;
int CantidadComprada = 0;
float TotalFactura = 0;
Console.WriteLine("Ingrese el costo unitario del producto (0 para terminar):");
CostoUnitario = float.Parse(Console.ReadLine());
while (CostoUnitario > 0)
{
    Console.WriteLine("Ingrese la cantidad comprada del producto:");
    CantidadComprada = int.Parse(Console.ReadLine());
    TotalFactura += (float)(CostoUnitario * CantidadComprada);
    Console.WriteLine("Ingrese el costo unitario del producto (0 para terminar):");
    CostoUnitario = float.Parse(Console.ReadLine());
}
Console.WriteLine($"El total de la factura es: {TotalFactura}");
*/
//EJercicio 5
float Costo = 0;
Console.WriteLine("Ingrese la cantidad de productos utilizados por el cliente:");
int Cantidad = int.Parse(Console.ReadLine());
float Total = 0;
for (int i = 0; i < Cantidad; i++)
{
    Console.WriteLine($"Ingrese el costo del producto {i + 1}:");
    Costo += float.Parse(Console.ReadLine());
    Total += Costo;
}
Console.WriteLine($"El total adeudado es: {Total}");
