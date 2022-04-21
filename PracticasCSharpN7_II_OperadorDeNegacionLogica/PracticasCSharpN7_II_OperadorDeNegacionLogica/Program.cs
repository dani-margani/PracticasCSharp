using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN7_II_OperadorDeNegacionLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;
            //int numero2 = numero + 1;

            int numero2 = ++numero * 2;

            Console.WriteLine(numero2);
            Console.WriteLine(numero);



            /*if (!(numero <=5)) //ejemplo de negacion logica
            {
                Console.WriteLine("Número es mayor que 5");
            }
            */


            /* bool variable1 = true;
            bool variable2 = !variable1; //Esto es un ejemplo previo dejo comentado el codigo para seguir con el ejercicio 

            Console.WriteLine(variable2);
            */

            Console.ReadKey();
            
        }
    }
}
