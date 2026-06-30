using System;
using System.Collections.Generic;
using System.Linq;
/*
//Ejericio 1
int suma(int a, int b)
{
    return a + b;
}
Console.WriteLine("Ingrese el primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"La suma es: {suma(num1, num2)}");

//Ejercicio 2
int SumarListas(List<int> numeros)
{
    int suma = 0;
    foreach (int n in numeros)
    {
        suma += n;
    }
    return suma;
}

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int resultado = SumarListas(numeros);
Console.WriteLine($"La suma de la lista es: {resultado}");

//Ejericio 3
int multiplicador(int a, int b)
{
    return a * b;
}

Console.WriteLine("Ingrese el primer numero: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
int num4 = int.Parse(Console.ReadLine());
Console.WriteLine($"La multiplicación es: {multiplicador(num3, num4)}");

//Eejricio 4
string vocales(string texto)
{
    int cantidadVocales = 0;
    foreach (char c in texto)
    {
        if ("aeiouAEIUO".Contains(c))
        {
            cantidadVocales++;
        }
    }
    return cantidadVocales.ToString();
}

Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();
vocales(texto);
Console.WriteLine($"La cantidad de vocales en el texto es: {vocales(texto)}");

//Ejercicio 5
string palabraMasGrande(string[] frase)
{
    string fraseMasLarga = "";
    foreach (string f in frase)
    {
        if (f.Length > fraseMasLarga.Length)
        {
            fraseMasLarga = f;
        }
    }
    return fraseMasLarga;
}

Console.WriteLine("Ingrese una frases: ");
string[] frases = Console.ReadLine().Split(" ");
string resultado = palabraMasGrande(frases);
Console.WriteLine($"La frase más larga es: {resultado}");

//Ejercicio 7
int[] tablaDeMultiplicar(int[] tabla, int numero)
{
    for (int i = 0; i < 10; i++)
    {
        tabla[i] = numero * (i + 1);
    }
    return tabla;
}

Console.WriteLine("Ingrese un numero: ");
int num5 = int.Parse(Console.ReadLine());
int[] tabla = new int[10];
int[] resultado = tablaDeMultiplicar(tabla, num5);
Console.WriteLine($"La tabla de multiplicar del {num5} es: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{num5} * {i + 1} = {resultado[i]} \n");
}
Console.WriteLine();

//Ejercicio 8
string letraRepetida(string texto, char letra)
{
    int cantidad = 0;
    foreach (char c in texto)
    {
        if (c == letra)
        {
            cantidad++;
        }
    }
    return cantidad.ToString();
}

Console.WriteLine("Ingrese un texto: ");
string texto2 = Console.ReadLine();
Console.WriteLine("Ingrese la letra letra que desee saber cuantas repetidas tiene: ");
char letra = char.Parse(Console.ReadLine());
Console.WriteLine($"la letra {letra} se repite {letraRepetida(texto2, letra)} veces");

//Ejercicio 10
void numerosPares(int n1, int n2)
{
    for (int i = n1; i <= n2; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("Ingrese el primer numero: ");
int num6 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero (tiene que ser mayor al primero): ");
int num7 = int.Parse(Console.ReadLine());
Console.WriteLine($"los pares entre {num6} y {num7} son: ");
numerosPares(num6, num7);

//Ejercicio 11
void devuelveAlRwves(int[] arreglo)
{
    for (int i = arreglo.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(arreglo[i]);
    }
}

int[] numeros1 = new int[10];
for (int i = 0; i < numeros1.Length; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    int num8 = int.Parse(Console.ReadLine());
    numeros1[i] = num8;
}
Console.WriteLine("Estos son los numeros ingresados de atras para adelante: ");
devuelveAlRwves(numeros1);
*/
//Ejercicio 12
string tipoNumero(int n1)
{
    if (n1 < 0)
    {
        return "Negativo";
    }
    else if (n1 > 0)
    {
        return "Positivo";
    }
    else
    {
        return "0";
    }
}

Console.WriteLine("Ingrese un numero: ");
int num9 = int.Parse(Console.ReadLine());
string tipoDeNumero = tipoNumero(num9);
Console.WriteLine($"EL numero ingresado es {tipoDeNumero}");
