using System;
using System.Collections.Generic;
using System.Linq;

//Ejercicio 1
Console.WriteLine("califica el sevicio (1-5) 0 para salir: ");
int calificacion =int.Parse(Console.ReadLine());
int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
int usuarios = 0;
while (calificacion != 0)
{
    if (calificacion < 1 || calificacion > 5)
    {
        Console.WriteLine("Calificacion incorrecta, intente de nuevo");
    }
    else
    {
        if (calificacion == 1)
        {
            n1++;
        }
        else if (calificacion == 2)
        {
            n2++;
        }
        else if (calificacion == 3)
        {
            n3++;
        }
        else if (calificacion == 4)
        {
            n4++;
        }
        else if (calificacion == 5)
        {
            n5++;
        }
        usuarios++;
    }
    Console.WriteLine("califica el sevicio (1-5) 0 para salir: ");
    calificacion = int.Parse(Console.ReadLine());
}
if (usuarios > 0)
{
    Console.WriteLine($"Calificacion 1: {(float)n1 / usuarios * 100}%");
    Console.WriteLine($"Calificacion 2: {(float)n2 / usuarios * 100}%");
    Console.WriteLine($"Calificacion 3: {(float)n3 / usuarios * 100}%");
    Console.WriteLine($"Calificacion 4: {(float)n4 / usuarios * 100}%");
    Console.WriteLine($"Calificacion 5: {(float)n5 / usuarios * 100}%");
}
else
{
    Console.WriteLine("No se registraron calificaciones");
}

//Ejercicio 2
int CursoA = 0, CursoB = 0, CursoC = 0;
Console.WriteLine("Ingrese en que curso queire estar (A, B, C) o X para salir: ");
string opcion = Console.ReadLine().ToUpper();
while (opcion != "X")
{
    if (opcion == "A") CursoA++;
    else if (opcion == "B") CursoB++;
    else if (opcion == "C") CursoC++;
    else Console.WriteLine("Curso no valido, intente de nuevo");
    Console.WriteLine("Ingrese en que curso queire estar (A, B, C) o X para salir: ");
    opcion = Console.ReadLine().ToUpper();
}
Console.WriteLine($"Curso A: {CursoA} alumnos");
Console.WriteLine($"Curso B: {CursoB} alumnos");
Console.WriteLine($"Curso C: {CursoC} alumnos");

//Ejercicio 3
int[] numeros = {1, 2, 3, 4, 5, 2, 1};
bool esSimetrico = true;

for (int i = 0; i < numeros.Length / 2; i++)
{
    if (numeros[i] != numeros[numeros.Length - 1 - i])
    {
        esSimetrico = false;
        break;
    }
}
if (esSimetrico)
{
    Console.WriteLine("El arreglo es simétrico");
}
else
{
    Console.WriteLine("El arreglo no es simétrico");
}

//Ejercicio 4
List<int> numeros1 = new List<int>();
Console.WriteLine("Ingrese numeros enteros (0 para terminar): ");
int n6 = int.Parse(Console.ReadLine());
int contador = 0;
while (n6 != 0)
{
    contador++;
    numeros1.Add(n6);
    Console.WriteLine("Ingrese numeros enteros (0 para terminar): ");
    n6 = int.Parse(Console.ReadLine());
}
List<int> sinrepetidos = new List<int>();
for (int i = 0; i < contador; i++)
{
    if (!sinrepetidos.Contains(numeros1[i]))
    {
        sinrepetidos.Add(numeros1[i]);
    }
}
Console.WriteLine("numeros sin repetir: ");
foreach (int num in sinrepetidos)
{
    Console.WriteLine(num);
}

//Ejericio 5
List<int> numeros2 = new List<int>();
Console.WriteLine("Ingrese números enteros (0 para terminar): ");
int n7 = int.Parse(Console.ReadLine());
while (n7 != 0)
{
    numeros2.Add(n7);
    Console.WriteLine("Ingrese números enteros (0 para terminar): ");
    n7 = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numeros2.Count - 1; i++)
{
    for (int j = 0; j < numeros2.Count - 1 - i; j++)
    {
        if (numeros2[j] > numeros2[j+1])
        {
            int aux = numeros2[j];
            numeros2[j] = numeros2[j+1];
            numeros2[j+1] = aux;
        }
    }
}
Console.WriteLine("Números ordenados: ");
foreach (int num1 in numeros2)
{
    Console.WriteLine(num1);
}

//Ejercicio 6
int[] numeros3 = {5,3,6,2,6,3,7,2,5,4};
int ultimo = numeros3[numeros3.Length - 1];

for (int i = numeros3.Length - 1; i > 0; i--)
{
    numeros3[i] = numeros3[i-1];
}
numeros3[0] = ultimo;
Console.WriteLine("arreglo rotado: ");
foreach (int num2 in numeros3)
{
    Console.WriteLine(num2);
}

//Ejercicio 7
Console.WriteLine("Ingrese una frase:");
string frase = Console.ReadLine().ToLower();
string[] palabras = frase.Split(' ');
Dictionary<string, int> conteo = new Dictionary<string, int>();
foreach (string palabra in palabras)
{
    if (conteo.ContainsKey(palabra))
    {
        conteo[palabra]++;
    }
    else
    {
        conteo[palabra] = 1;
    }
}
foreach (var par in conteo)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}

//Ejercicio 8
List<int> numeros4 = new List<int>();
Random rand = new Random();
while (numeros4.Count < 10)
{
    int n8 = rand.Next(1, 21);
    if (!numeros4.Contains(n8))
    {
        numeros4.Add(n8);
    }
}
Console.WriteLine("Nuemros aleatorios sin repetir generados: ");
foreach (int num3 in numeros4)
{
    Console.WriteLine(num3);
}

//Ejericio 9
List<string> tareas = new List<string>();
List<bool> estados = new List<bool>();
int opcion;
do
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1. Ver tareas");
    Console.WriteLine("2. Agregar tarea");
    Console.WriteLine("3. Eliminar tarea");
    Console.WriteLine("4. Cambiar estado");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("\nLista de tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                string estado = estados[i] ? "Completada" : "Pendiente";
                Console.WriteLine($"{i + 1}. {tareas[i]} - {estado}");
            }
            break;
        case 2:
            Console.Write("Ingrese la nueva tarea: ");
            string nueva = Console.ReadLine();
            tareas.Add(nueva);
            estados.Add(false);
            break;
        case 3:
            Console.Write("Ingrese el índice de la tarea a eliminar: ");
            int eliminar = int.Parse(Console.ReadLine()) - 1;

            if (eliminar >= 0 && eliminar < tareas.Count)
            {
                tareas.RemoveAt(eliminar);
                estados.RemoveAt(eliminar);
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            break;
        case 4:
            Console.Write("Ingrese el índice de la tarea a cambiar estado: ");
            int cambiar = int.Parse(Console.ReadLine()) - 1;

            if (cambiar >= 0 && cambiar < estados.Count)
            {
                estados[cambiar] = !estados[cambiar];
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != 5);