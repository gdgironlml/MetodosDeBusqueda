using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Debe estar ordenador para la busqueda binaria

        Console.WriteLine("Escriba un numero del 1 al 10 para buscar:");

        string entrada = Console.ReadLine();
        int objetivo = int.Parse(entrada);

        Console.WriteLine("Elija una opción para buscar:\n" +
                          "1. Método Lineal\n" +
                          "2. Método Binario\n");

        string entradaEleccion = Console.ReadLine();
        int eleccion = int.Parse(entradaEleccion);

        if (eleccion == 1)
        {
            int resultadoLineal = BusquedaLineal(numeros, objetivo);
            Console.WriteLine($"El número es {objetivo} y está en el índice: {resultadoLineal}");
        }
        if (eleccion == 2)
        {
            int resultadoBinario = BusquedaBinaria(numeros, objetivo);
            Console.WriteLine($"El número es {objetivo} y está en el índice: {resultadoBinario}");
        }     
    }

    static int BusquedaLineal(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Buscando en {arr[i]}...");
            if (arr[i] == x) return i;
        }
        return -1;
    }

    static int BusquedaBinaria(int[] arr, int x)
    {
        int bajo = 0;
        int alto = arr.Length - 1;

        while (bajo <= alto)
        {
            int medio = bajo + (alto - bajo) / 2;
            Console.WriteLine($"Buscando en {arr[medio]}...");

            if (arr[medio] == x) return medio;

            if (arr[medio] < x)
                bajo = medio + 1;
            else
                alto = medio - 1;
        }
        return -1;
    }
}