using System;
using System.Collections.Generic;

class DiccionarioInglesEspanol
{
    static void Main()
    {
        SortedList<string, string> diccionario = new SortedList<string, string>();

        // Palabras del diccionario
        diccionario.Add("hello", "hola");
        diccionario.Add("bye", "adios");
        diccionario.Add("please", "por favor");
        diccionario.Add("thanks", "gracias");
        diccionario.Add("yes", "sí");
        diccionario.Add("no", "no");
        diccionario.Add("good morning", "buenos dias");
        diccionario.Add("good night", "buenas noches");

        string palabra;

        // Pide una palabra en ingles al usuario
        Console.WriteLine("Introduce una palabra en ingles para obtener la traducción en español (deja vacio para salir):");

        do
        {
            palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                // Verifica si la palabra existe en el diccionario
                if (diccionario.ContainsKey(palabra))
                {
                    Console.WriteLine($"La traducción de '{palabra}' es: {diccionario[palabra]}");
                }
                else
                {
                    Console.WriteLine($"La palabra '{palabra}' no está en el diccionario.");
                }
            }

        } while (!string.IsNullOrEmpty(palabra)); // Repite hasta que el usuario deje la palabra vacia

        Console.WriteLine("Programa finalizado.");
    }
}
