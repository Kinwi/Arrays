using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               4.Crear un array de 3 ints. Usar un for para pedir al usuario que 
               introduzca valores a cada una de las posiciones. 
               Usar otro for para mostrarlos en pantalla.

           */

            int[] arrayNumeros = new int[3];

            for (int i = 0; i < arrayNumeros.Length; i++)


            {
                Console.WriteLine("Introduzca el numero " + (i +1));
                int numero = Convert.ToInt32(Console.ReadLine());
                arrayNumeros[i] = numero;

            }

            

            for (int i = 0; i < arrayNumeros.Length; i++)


            {

                Console.WriteLine(arrayNumeros[i]);

            }
        }
    }
}
