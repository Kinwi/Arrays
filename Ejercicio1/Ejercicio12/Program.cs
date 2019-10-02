using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12.Ordenar un array de 5 strings alfabéticamente:
            Utilizar función.
            Sin función. (Muy dificil)
            */

            string[] arrayPalabras = new string[5];

            Console.WriteLine("Inserte 5 palabras para ordenar");


            for (int i = 0; i < arrayPalabras.Length; i++)

            {
                string palabras = Console.ReadLine();
                arrayPalabras[i] = palabras;
            }

            // Creamos un comparador que ordene de manera ascendente alfabeticamente

            Comparison<string> comparador = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));
            
            // Llamar a Array.Sort, pasando el arreglo a ordenar y el comparador

            Array.Sort<string>(arrayPalabras, comparador);

            // Ahora simplemente imprimimos
            Console.WriteLine("Las palabras ordenadas alfabeticamente quedaran asi");
            Console.WriteLine();
            foreach (string palabra in arrayPalabras)
            {
                Console.WriteLine(palabra);

        }  }
    }
}
