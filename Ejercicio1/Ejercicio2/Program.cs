using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               2.Crear un array de 3 strings. 
               Pedir al usuario 3 veces que escriba un string.
               Guardar cada uno de esos strings en la posición 0 , 1 y 2.
               Mostrar en pantalla en el orden: 

           */

            string[] arrayPalabras = new string[3];

            Console.WriteLine("Escribe tres palabras");

            
            for (int i = 0; i < arrayPalabras.Length; i++)

            {

                string palabra = Console.ReadLine();

                 arrayPalabras[i] = palabra;

            }

            for (int i = 0; i < arrayPalabras.Length; i++)

            {

                Console.Write(arrayPalabras[i]);

            }


        }
    }
}
