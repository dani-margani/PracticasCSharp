using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero; // Declaramos la variable
            //numero = 8; // Le asignamos un valor

            //int numero2 = 25; // Se puede declara todo en una linea

            // numero = 15; //Acá no es necesario volver a declarar la variable xq ya sabe q es un num entero
            //Console.WriteLine(numero);

            /* int numero1 = 8;
             int numero2 = 12;

             int suma = numero1 + numero2; // Esto es una asignacion, le estamos asignando el resultado de la suma de 2 variables. No es un formula matematica, num x = 3+, etc, no se puede.

             Console.WriteLine(suma);
             Console.ReadKey();*/

            //Ejercicio dos
            Console.WriteLine("Introduce dos números y los sumaré:");
            int numero1 = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine lee la consola y lo convierte en un string. Lo convertimos a int 32 y lo almacenamos dentro de numero1
                                                               // int numero1 = Convert.ToInt32("35") va a convertir cualquier texto entre "" y lo va a convertir en un entero.
            Console.WriteLine("Introduce el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
            int suma = numero1 + numero2;

            Console.WriteLine("La suma de los dos números es:");

            Console.WriteLine(suma);
            Console.ReadKey();
            

        }
    }
}
