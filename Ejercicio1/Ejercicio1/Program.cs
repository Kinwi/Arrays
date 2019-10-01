using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1.Crear un array de 10 ints.
                Asignar un valor a cada uno de las 10 posiciones.Mostrar los 10 valores en pantalla.

            */

            
            int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int i = 0; i < array.Length; i++)

            {
                Console.WriteLine(array[i]);
            }
            
            
        }
    }
}
