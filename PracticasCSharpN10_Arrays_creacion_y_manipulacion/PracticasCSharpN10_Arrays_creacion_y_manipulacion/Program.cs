using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN10_Arrays_creacion_y_manipulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 12, 15, 18, 22, 235 };   //new int[5];

            numeros[3] = 999;

            /*
             numeros[0] = 3;
             numeros[1] = 13;
             numeros[2] = 32;
             numeros[3] = 83;
             numeros[4] = 123;
            */


            /*
             * for (int contador = 0 ; contador < numeros.Length; contador ++)
            {
                Console.WriteLine("El elemento " + (contador + 1 ) + " es igual a " + numeros[contador]);
            }*/

            int[] numero2 = new int[10];
            

            for(int contador = 0; contador < numeros.Length; contador++)
            {
                numero2[contador] = numeros[contador];
            }

            numeros = numero2;

            for (int contador = 0; contador < numero2.Length; contador++ )
            {
                Console.WriteLine("El elemento " + (contador + 1) + " es igual a " + numeros[contador]);
            }

            

            //int suma = numeros[0] + numeros[1] + numeros[2] + numeros[2] + numeros[3] + numeros[4];
            //Console.WriteLine(suma);
            // numeros[5] = 2; ESTO ES UN ERROR XQ EL ARRAY TIENE 5 ESPACIOS Y EL 0 CUENTA COMO EL 1RO

            Console.ReadKey();
        }
    }
}
