using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

// 1. Suma de elementos pares en un arreglo
static int SumaPares(int[] arreglo)
{
    int suma = 0;
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] % 2 == 0)
        {
            suma += arreglo[i];
        }
    }
    return suma;
}

int[] arreglo = { 10, 1, 3, 4, 5, 12 };
int suma = SumaPares(arreglo);
Console.WriteLine("\t.:Suma de elementos pares en un arreglo:.");
Console.WriteLine("Arreglo: " + string.Join(", ", arreglo));
Console.WriteLine("La suma de los elementos pares del arreglo es: " + suma);
Console.ReadLine();
Console.Clear();

//2. Invertir el orden de un arreglo
static int[] InvertirOrden(int[] arreglo2)
{
    int[] arregloInvertido = new int[arreglo2.Length];
    for (int i = 0; i < arreglo2.Length; i++)
    {
        arregloInvertido[i] = arreglo2[arreglo2.Length - 1 - i];
    }
    return arregloInvertido;
}

int[] arreglo2 = { 2, 4, 5, 6, 8 };
int[] arregloInvertido = InvertirOrden(arreglo2);
                                        
//String.Join: Une los elementos de una coleccion en una sola cadena con el delimitador ", "
Console.WriteLine("\t.:Invertir el orden de un arreglo:.");
Console.WriteLine("Arreglo Original: " + string.Join(", ", arreglo2));
Console.WriteLine("Arreglo Invertido: " + string.Join(", ", arregloInvertido));
Console.ReadLine();
Console.Clear();

//3. Encontrar el valor maximo en un arreglo
static int ValorMaximo(int[] arreglo3)
{
    int Maximo = arreglo3[0];
    for(int i= 1; i<arreglo3.Length; i++)
    {
        if(arreglo3[i] > Maximo)
        {
            Maximo = arreglo3[i];
        }
    }
    return Maximo;
}
int[] arreglo3 = { 5, 2, 4, 7, 80, 9 };
int Maximo = ValorMaximo(arreglo3);
Console.WriteLine("\t.:Encontrar el valor maximo en un arreglo:. ");
Console.WriteLine("Arreglo: " + string.Join(", ", arreglo3));
Console.WriteLine("El valor máximo en el arreglo es: " + Maximo);
Console.ReadLine ();
Console.Clear();


//4. Buscar un elemento en un arreglo
static int BuscarElemento(int[] arreglo4, int valor)
{
    for(int i= 0; i<arreglo4.Length; i++)
    {
        if (arreglo4[i] == valor)
        {
            return i;
        }
    }
    return -1;
}
int[] arreglo4 = { 3, 4, 5, 2, 69 };
int posicion = BuscarElemento(arreglo4, 2);
Console.WriteLine("\t.:Buscar elemento en un arreglo:.");
Console.WriteLine("Arreglo: " + String.Join(", ", arreglo4 ));
Console.WriteLine("La posición del valor 2 en el arreglo es: " + posicion);
Console.ReadLine ();
Console.Clear();

//5. Ordenar un arreglo de forma ascendente
static int[] Ordenar(int[] arreglo5)
{
    int[] copiaArreglo = arreglo5.ToArray();//Copia los elementos
    Array.Sort(copiaArreglo );
    return copiaArreglo ;
}
int[] arreglo5 = { 10, 9, 8, 7, 6, 5 };
int[] arregloOrdenado = Ordenar(arreglo5);

Console.WriteLine("\t.:Ordenar arreglo de forma ascendente:.");
Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo5));
Console.WriteLine("Arreglo ordenado: " + string.Join(", ", arregloOrdenado));
Console.ReadLine();
Console.Clear();

//Utilización de métodos de Array
// 1. Ordenar nombres alfabéticamente
static void OrdenarNombres(string[] nombres)
{
    Array.Sort (nombres);
    foreach (string item in nombres)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
    Console.Clear();
}

static void Ejercicio1 ()
{
    Console.Write("Ingrese los nombres separados por comas: ");
    string input = Console.ReadLine();
    string[] nombres = input.Split(',');
    OrdenarNombres (nombres);
}

//2. Encontrar un valor maximo y valor minimo
static void NumMaximo(int[] numeros)
{
    int maximo = numeros.Max();
    Console.WriteLine("El valor máximo de la lista es: " + maximo);
}

static void NumMinimo(int[] numeros)
{
    int minimo = numeros.Min();
    Console.WriteLine("El valor minimo de la lista es: " + minimo);
    Console.ReadLine();
    Console.Clear();
}
static void Ejercicio2()
{
    Console.Write("Ingrese una lista de numeros enteros separados por comas: ");
    string input = Console.ReadLine();
    string[] numerosStg = input.Split(',');
    int[] numeros = Array.ConvertAll(numerosStg, int.Parse);

    NumMaximo (numeros);
    NumMinimo (numeros);

}

//3. Buscar nombre de un pais en un arreglo

static void BuscarNombre(string[] nombres, string nombre)
{
    int indice = Array.IndexOf(nombres, nombre);
    if(indice != -1)
    {
        Console.WriteLine($"El país '{nombre}' fue encontrado en la posición {indice} del arreglo.");
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"El país '{nombre}' no fue encontrado en el arreglo.");
        Console.ReadLine();
        Console.Clear();
    }
}
static void Ejercicio3()
{
    string[] nombres = new string[] { "Alemania", "Mexico", "Egipto", "Brasil", "India", "España", "Francia"}.Select(nombre => nombre.ToLower()).ToArray(); 
    Console.Write("Ingrese nombre de un pais: ");
    string nombre = Console.ReadLine().ToLower();

    BuscarNombre (nombres,nombre);
}

//4. Invertir orden de un arreglo
static void ImprimirArreglo(int[] enteros)
{
    foreach (int item in enteros)
    {
        Console.WriteLine(item + " ");
    }
    Console.WriteLine();

}
static void Ejercicio4()
{
    int[] enteros = new int[] { 5, 4, 3, 2, 1 };
    Console.WriteLine("\t.:Invertir orden de un arreglo:.");
    Console.WriteLine("Arreglo Original: ");
    ImprimirArreglo (enteros);

    Console.WriteLine("Arreglo Invertido: ");
    Array.Reverse (enteros);
    ImprimirArreglo(enteros);

    Console.ReadLine();
    Console.Clear();
}

//5. Calificaciones
static void Sobresaliente(int[] calificaciones)
{
    bool Sobresaliente = Array.Exists(calificaciones, calif => calif >= 90);
    if(Sobresaliente)
    {
        Console.WriteLine("¡Si hay calificaciones sobresalientes!");
        
    }
    else
    {
        Console.WriteLine("¡No hay calificaciones sobresalientes!");
        
    }
    Console.ReadLine();
    Console.Clear();
}
static void Ejercicio5()
{
    Console.Write("Ingrese calificaciones separadas por comas: ");
    string input = Console.ReadLine();
    string[] CalificacionStg = input.Split(',');
    int[] calificaciones = Array.ConvertAll(CalificacionStg, int.Parse);

    Sobresaliente(calificaciones);
}

Ejercicio1();
Ejercicio2();
Ejercicio3();
Ejercicio4();
Ejercicio5();