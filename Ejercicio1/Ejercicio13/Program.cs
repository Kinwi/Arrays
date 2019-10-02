using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                13. Cargar una tabla de 20 elementos donde cada elemento almacenará un valor entre 1 y 9 
                (genéralos de forma aleatoria) y escribir, además del contenido de la tabla, 
                la cantidad de 1, cantidad de 2, cantidad de 3…, cantidad de 9 almacenados en ella.

           */

            Random aleatorio = new Random();
            int[] numerosRandom = new int[20];
            int[] posicion = new int[10];
            for (int i = 0; i < numerosRandom.Length; i++)
            {
                numerosRandom[i] = aleatorio.Next(1, 10);
                posicion[numerosRandom[i]]++;
            }

            for (int i = 0; i < numerosRandom.Length; i++) 
            {
                Console.WriteLine(i + "\t" + numerosRandom[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < posicion.Length; i++)
            {
                Console.WriteLine($"El {i} aparece {posicion[i]} veces");
            }


        }
    }    
}
