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

            

            int[] arrayNumeros = new int[20];
            int[] arrayFrecuencias = new int[10];

            Random aleatorio = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                int numeros = aleatorio.Next(1, 10);
                arrayNumeros[i] = numeros;

            }
            for (int j = 0; j < arrayNumeros.Length; j++)
            {
                // En el arrayNumeros los numeros entran aleatorios
                // Ejemplo 9,8,9,2,8,6,5,4,7 ....

                // En el arrayFrecuencias los numeros entran posicionados marcando cuantos hay
                // Ejemplo 9 con frecuencia 2 , 7 con frecuencia 4 etc
                arrayNumeros[arrayFrecuencias[j]]++;
                    
                }


            

            Console.WriteLine(arrayFrecuencias[0] + "-------------" + arrayNumeros[0]);


        }
    }    
}
