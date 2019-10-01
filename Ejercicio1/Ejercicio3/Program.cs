using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               3.Crear un array de 10 ints. Usar un for para asignar los valores de
               20 a 11 a las 10 posiciones 
               (en orden descendente).
               Usar un for para mostrar los 10 valores en pantalla

           */

            int j = 0;
            int[] array = new int[10];

            for (int i = 20; i > array.Length; i--) {

                array[j] = i;
                j++;
            }

            for (int i = 0; i < array.Length; i++)
                
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
