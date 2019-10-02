using System;

namespace Ejercicio11PRO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             . 1.Cargar una tabla de 20 componentes enteros y 
             calcular la suma de los componentes de posición par y  
             el producto de los componentes de posición impar.
             Los valores se generarán aleatoriamente entre 1 y 100.
            
            */

            int[] arrayTabla = new int[20];
            int sumarIndicesPares = 0;
            int multiplicarIndicesImpares = 1;
            Random aleatorio = new Random();

            Console.WriteLine("Introduce 20 valores enteros");

            for (int i = 0; i <arrayTabla.Length; i++)
            {
                int numeros = aleatorio.Next(1, 101);
                arrayTabla[i] = numeros;

            }

            for (int i = 0; i < arrayTabla.Length; i++)

            {
                
                if (i % 2 == 0)
                {
             
                    sumarIndicesPares = sumarIndicesPares + arrayTabla[i];
                    
                }

                else 
                {

                    multiplicarIndicesImpares = multiplicarIndicesImpares * arrayTabla[i];
                }
                
            }
            Console.WriteLine("La suma de los valores generados aleatoriamente de indice par es " + sumarIndicesPares);
            Console.WriteLine("La multiplicacion de los valores generados aleatoriamente de indice impar es " + multiplicarIndicesImpares);


        }
    }
}
