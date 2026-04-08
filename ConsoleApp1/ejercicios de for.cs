using System.Diagnostics.CodeAnalysis;
/*
//Ejercicio 1
int suma = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un numero");
    int numero = int.Parse(Console.ReadLine());
    suma += numero;
}
Console.WriteLine($"La suma de los numero es: {suma}");

//Ejercicio 2
int sum = 0;
int promedio = 0;
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    sum = int.Parse(Console.ReadLine());
    promedio = sum / 8;
}
Console.WriteLine($"El promedio de los numero es: {promedio}");

//Ejercicio 3
float CostoUnitario = 0;
int CantidadComprada = 0;
float TotalFactura = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el costo unitario del producto");
    Console.WriteLine("Ingrese la cantidad comprada del producto");
    CostoUnitario = float.Parse(Console.ReadLine());
    CantidadComprada = int.Parse(Console.ReadLine());
    float Total = CostoUnitario * CantidadComprada;
    TotalFactura += Total;
}
Console.WriteLine($"El total de la factura es: {TotalFactura}");
*/
//Ejercicio 4
int numero;
int mayor = 0;
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        mayor = numero;
    }
    else if (numero > mayor)
    {
        mayor = numero;
    }
}
Console.WriteLine($"El numero mayor es: {mayor}");
/*
//Ejericicio 5
string Cliente;
float TotalCompra = 0;
float MayorGasto = 0;
string MayorCliente = "";

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el nombre del cliente");
    Cliente = Console.ReadLine();
    Console.WriteLine("Ingrese el total de la compra del cliente");
    TotalCompra = float.Parse(Console.ReadLine());
    if (i == 0)
    {
        MayorGasto = TotalCompra;
        MayorCliente = Cliente;
    }
    else if (TotalCompra > MayorGasto)
    {
        MayorGasto = TotalCompra;
        MayorCliente = Cliente;
    }
}
Console.WriteLine($"El cliente de mas gasto es: {MayorCliente}, con un gasto de: {MayorGasto}");

//Ejercicio 6
Console.WriteLine("Ingrese un numero:");
int n = int.Parse(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}
Console.WriteLine($"El factorial de {n} es: {factorial}");

//Ejercicio 7
Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());
for (int i = 0; i < numero; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/