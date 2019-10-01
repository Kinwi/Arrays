using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             6.Poner los nombres de los meses en un array de 12. 
             Cuando el usuario introduce un número del 1 al 12, 
             mostrar el nombre de ese mes en pantalla.

          */

            string[] meses= { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio","Julio", "Agosto", "Septiembre", "Octubre","Noviembre","Diciembre" };
            Console.WriteLine("Escribe un numero del 1 al 12");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)

            {
                case 1:
                    Console.WriteLine(meses[0]);
                    break;
                case 2:
                    Console.WriteLine(meses[1]);
                    break;
                case 3:
                    Console.WriteLine(meses[2]);
                    break;

                case 4:
                    Console.WriteLine(meses[3]);
                    break;
                case 5:
                    Console.WriteLine(meses[4]);
                    break;
                case 6:
                    Console.WriteLine(meses[5]);
                    break;
                case 7:
                    Console.WriteLine(meses[6]);
                    break;
                case 8:
                    Console.WriteLine(meses[7]);
                    break;
                case 9:
                    Console.WriteLine(meses[8]);
                    break;

                case 10:
                    Console.WriteLine(meses[9]);
                    break;
                case 11:
                    Console.WriteLine(meses[10]);
                    break;
                case 12:
                    Console.WriteLine(meses[11]);
                    break;


                default:
                    Console.WriteLine("El valor introducido no es correcto");
                    break;
         }  }
    }
}
