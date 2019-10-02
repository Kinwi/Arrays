using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             9.Crear un array de 10 valores. Poner el valor 1 en cada una de la posición.
             Pedir al usuario que introduzca un número entre 0 y 9. Cada vez que introduzca un valor entre 0 y 9, 
             mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.
             */

            int [] arrayNumeros = new int[10];
           
            

            for (int i = 0; i < arrayNumeros.Length; i++)
            {

                arrayNumeros[i] = 1;
                Console.WriteLine("El valor de la celda de indice " + i + " es " + arrayNumeros[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Introduce un numero del 0 al 9");

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0 && numero <= 9)
                {
                    arrayNumeros[i] = numero;

                    Console.WriteLine("El valor de la posicion " + i + " inicial es " + numero);
                    Console.WriteLine("El valor de la posicion es " + i + " duplicada es " + numero * 2);
                }
        }   }
    }
}

