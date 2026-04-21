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
*/
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
int BusArreglo = 23;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == BusArreglo)
    {
        Console.WriteLine($"El número {BusArreglo} se encuentra en el arreglo.");
        break;
    }
}

int BusLista = 9;
for (int i = 0; i < calificaciones.Count; i++)
{
    if (calificaciones[i] == BusLista)
    {
        Console.WriteLine($"El número {BusLista} se encuentra en la lista.");
        break;
    }
}

//Ejericio 4
List<int> numeros = new List<int>();
for (int i = 0; i < 5; i++)
{
    
}