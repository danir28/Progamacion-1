using System;
using System.Collections.Generic;
using System.Linq;
/*
//Ejericio 1
int[] numeros = new int[5];
int suma = 0;
numeros[0] = 43;
numeros[1] = 12;
numeros[2] = 65;
numeros[3] = 23;
numeros[4] = 9;

for (int i = 0; i < 5; i++)
{
    suma += numeros[i];
}
Console.WriteLine($"La suma de los números es: {suma} ");

//Ejercicio 2
List<int> calificaciones = new List<int>();
int suma1 = 0;
int promedio = 0;
calificaciones.Add(5);
calificaciones.Add(8);
calificaciones.Add(9);
calificaciones.Add(7);
calificaciones.Add(6);
for (int i = 0; i < calificaciones.Count; i++)
{
    suma1 += calificaciones[i];
}
promedio = suma1 / calificaciones.Count;
Console.WriteLine($"El promedio de las calificaciones es: {promedio} ");

//Ejercicio 3
int Buscado = 23;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == Buscado)
    {
        Console.WriteLine($"El número {Buscado} se encuentra en el arreglo.");
        break;
    }
}

calificaciones.IndexOf(23);
if (calificaciones.Contains(Buscado))
{
    Console.WriteLine($"El número {Buscado} se encuentra en la lista.");
}
else
{
    Console.WriteLine($"El numero {Buscado} no se encuentre en la lista.");
}

//Ejericio 4
List<int> numeros = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un número:");
    int n = int.Parse(Console.ReadLine());
    numeros.Add(n);
}
numeros.Sort();
numeros.Reverse();
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

//Ejercicio 5
int[] num = new int[5];
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine("Ingrese un número:");
    int n1 = int.Parse(Console.ReadLine());
    num[i] = n1;
}
Console.WriteLine("Los numeros pares ingresados son: ");
for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        Console.WriteLine(num[i]);
    }
}

//Ejercicio 6
List<int> nuemros1 = new List<int>();
Console.WriteLine("Ingrese un numero: ");
int n2 = int.Parse(Console.ReadLine());
while (n2 != 0)
{
    nuemros1.Add(n2);
    Console.WriteLine("Ingrese un numero (si quiere salir ingrese 0): ");
    n2 = int.Parse(Console.ReadLine());
}
Console.WriteLine("ingrese el numero del que quiere conocer la cantidad: ");
int infon2 = int.Parse(Console.ReadLine());
int contador = 0;
for (int i = 0; i < nuemros1.Count; i++)
{
    if (nuemros1[i] == infon2)
    {
        contador += 1;
    }
}
Console.WriteLine($"El numero {infon2} se encuentra {contador} veces en la lista");

//Ejercicio 7
List<string> nombres = new List<string>();
Console.WriteLine("Ingrese un nombre (si ingresas fin termina): ");
string nomb = Console.ReadLine();
while (nomb != "fin")
{
    nombres.Add(nomb);
    Console.WriteLine("Ingrese un nombre (si ingresas fin termina): ");
    nomb = Console.ReadLine();
}

//Ejercicio 8
string[] nombres1 = new string[5];
for (int i = 0; i < nombres1.Length; i++)
{
    Console.WriteLine("Ingrese un nombre: ");
    string nomb1 = Console.ReadLine();
    nombres1[i] = nomb1;
}
Array.Reverse(nombres1);
foreach (string nomb1 in nombres1)
{
    Console.WriteLine(nomb1);
}

//Ejercicio 9
List<int> numeros2 = new List<int>();
Console.WriteLine("Ingrese un numero: ");
int n3 = int.Parse(Console.ReadLine());
while (n3 != 0)
{
    numeros2.Add(n3);
    Console.WriteLine("Ingrese un numero (si quiere salir ingrese 0): ");
    n3 = int.Parse(Console.ReadLine());
}
int max = numeros2.Max();
int min = numeros2.Min();
Console.WriteLine($"El numero mayor es: {max}, y el minimos es {min}");
*/
//Ejercicio 10
