using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
           8. Crear un array de 11 ints.Pedir al usuario que introduzca valores entre 0 y 10.
           Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array.
           Si por ejemplo introduce un 3, sumar uno a la posición 
           3.Mostrar en pantalla los valores. Si introduce un número mayor que 10, decir que ese número
           es incorrecto. Si introduce un número negativo, mostrar en pantalla el número de cada posición 
           y el valor que contiene.Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:

           */
            int[] array = new int[11];
            int num;
            do
            {
                Console.WriteLine("Introduce un número entre el 0 y el 10");
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 10)
                    {
                        Console.WriteLine("Número incorrecto");
                    }
                    else if (num >= 0 && num <= 10)
                    {
                        array[num]++;
                    }
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.WriteLine($"{i} se ha introducido {array[i]} veces");
​
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tienes que introducir un número entero");
                }
​
            } while (num >= 0);


        }
}   }
