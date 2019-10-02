using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
             10.Programa que lee las edades de 20 alumnos (validado entre 18 y 35), 
             las almacena en un array y calcula y escribe su media 
             (para probar, se pueden generar aleatoriamente entre 18 y 35).
             */

            int[] arrayEdades = new int[20];


            Random aleatorio = new Random();

            int sumarEdades = 0;
            for (int i = 0; i < arrayEdades.Length; i++)
            {
                int numeros18a35 = aleatorio.Next(18, 36);

                arrayEdades[i] = numeros18a35;
                Console.WriteLine(arrayEdades[i] + "      " + i);
                sumarEdades = sumarEdades + arrayEdades[i];
            }
            Console.WriteLine("La media de las edades generadas aleatoriamente sera " + sumarEdades / 20);
            

        }
    }
}
