using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Hacer la media de 10 valores utilizando un array.

            Console.WriteLine("Introduce 10 valores");

            int sumaArrays = 0;

            int[] arrayNumeros = new int[10];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                int numeros = Convert.ToInt32(Console.ReadLine());

                arrayNumeros[i] = numeros;

                sumaArrays = sumaArrays + arrayNumeros[i];

            }

            Console.WriteLine("La media de todos los numeros introducidos en el Array es : " + sumaArrays / 2);
            

        }
    }
}
