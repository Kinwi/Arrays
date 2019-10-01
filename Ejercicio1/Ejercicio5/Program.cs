using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              5.Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca
              valores a cada una de las posiciones. Mirar los valores del array una vez tenga
              los 3 valores y mostrar en pantalla el más pequeño.

           */

            int [] arrayNumeros = new int [3];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {

                Console.WriteLine("Introduzca el numero " + (i + 1));
                int numeros = Convert.ToInt32(Console.ReadLine());

                arrayNumeros[i] = numeros;

            }

            if (arrayNumeros[0] < arrayNumeros[1] && arrayNumeros[0] < arrayNumeros[2])

            {

                Console.WriteLine("El numero mas pequeño es " + arrayNumeros[0]);
            }
            else if (arrayNumeros[1] < arrayNumeros[0] && arrayNumeros[1] < arrayNumeros[2])

            {

                Console.WriteLine("El numero mas pequeño es " + arrayNumeros[1]);

            }

            else

            {
                Console.WriteLine("El numero mas pequeño es " + arrayNumeros[2]);

            }


        }
    }
}
