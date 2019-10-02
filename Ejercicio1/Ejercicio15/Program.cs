using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             15.Crear un array de dos dimensiones, de 5 posiciones cada una. Rellenar los valores con 0.
             Pedir al usuario dos números, utilizar eso como la posición de la 1 dimensión y la 2 dimensión 
             y poner un 1 en esa posición.
             Mostrar el array (en filas y columnas) en pantalla (deberían ser todo 0 menos un 1).
            */

           
          int[,] array = new int[5, 5]; // Creamos un array de 5 filas y 5 columnas

            // Utilizamos "i" y "j" para fijar la posicion de un numero

            Console.WriteLine("Introduzca dos numeros para fijar la posicion en el array 2d");

            int[] almacenarNumeros = new int[2];

            for (int i = 0; i < 3; i++)

            {
                int numeros = Convert.ToInt32(Console.ReadLine());
                almacenarNumeros[i] = numeros;
            }

            array[almacenarNumeros[0], almacenarNumeros[1]] =1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    array[i, j] = 0;
                    array[i, j] = 0;
                }
            }

            foreach (int i in array)
            {
                System.Console.Write("{0} ", i);
            }





        }
    }
}
