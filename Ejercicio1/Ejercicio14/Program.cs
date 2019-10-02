using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             14. Cargar dos tablas, una con los nombres y otra con las calificaciones de los N alumnos de una clase de Programación. 
            Rellenar arrays con el nombre del alumno y su nota validando entre 0 y 10. 
            Calcular la media de la clase
            Escribir los alumnos cuya nota es mayor que la media.
            Calcular la nota máxima y quienes la han conseguido
            Calcular la nota mínima y quienes la han conseguido
            Mostrar la lista de alumnos junto con su nota correspondiente: 
            Nombre1 Apellido11 Apellido12  - Nota 
            Nombre2 Apellido21 Apellido22  - Nota
          */
            Random aleatorio = new Random(); // Random para generar los numeros aleatorios (NOTAS)
            string[] alumnos = { "Adrian López", "Noelia Mínguez", "Mauricio Cavallini" };
            int[] notas = new int[3]; // N Alumnos. En este caso 3 alumnos
            double media, suma = 0, notaMax, notaMin;

            // Almacenamiento de notas generadas aleatoriamente

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = aleatorio.Next(1, 11);
                suma += notas[i];
            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + ",");
            }

            //Calculo de la media

            media = suma / notas.Length;
            Console.WriteLine();
            Console.WriteLine("la media de la clase es: " + media);

            // Comparas las notas del [] notas con la nota media sacada anteriormente. POR ENCIMA MEDIA

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= media)
                {
                    Console.WriteLine("Los alumnos con nota por encima de la media son: " + alumnos[i]);
                }
            }

            //ALUMN@ CON MAYOR NOTA

            //Parte de una nota . Numero X en posicion del array X y comparas con todas las notas
            // para saber cual es mayor. El pasar de una a otra se realiza con for (recorrer)

            notaMax = notas[2];
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > notaMax)
                {
                    notaMax = notas[i];
                }

            }
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= notaMax)
                {
                    Console.WriteLine("El/La alumn@s con la mayor nota es: " + alumnos[i]);
                }
            }

            // ALUMNO CON MENOR NOTA . 

            // Lo mismo que con lo anterior pero  fijando una nota como minima y comparando con esta

            notaMin = notas[2];
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < notaMin)
                {
                    notaMin = notas[i];
                }
            }
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= notaMin)
                {
                    Console.WriteLine("El/La alumn@s con la menor nota es: " + alumnos[i]);
                }
            }
            Console.WriteLine();

            // IMPRIMIR LAS NOTAS DE LOS ALUMNOS

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"El/la alumn@ {alumnos[i]} ha sacado un {notas[i]}");
            }


        }
    }
}
