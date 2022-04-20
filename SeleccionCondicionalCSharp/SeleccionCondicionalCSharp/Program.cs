using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleccionCondicionalCSharp // Seleccion condicional if, else, esle if, ifs anidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            //int edad = 13;
            // int edad = 28;

            /*if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if(edad < 0)
            {
                Console.WriteLine("La edad no puede ser negativa");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }*/

            
            //Anidados
            if(edad >= 0) // Si esta expresion es true, se ejecutara esto: if(edad >18 ) .Si es false se ejecutara la linea 47
            {
                if(edad >18) //  Si es true se ejecutará: Console.WriteLine("Eres mayor de edad");
                {
                    Console.WriteLine("Eres mayor de edad"); 
                }
                else
                {
                    Console.WriteLine("Eres menor de eddad"); //  Si f(edad >18) es false ejecutra esto
                }
            }
            else
            {
                Console.WriteLine("La edad no puede ser negativa"); // Si if(edad >= 0) es false, se ejecutara esto
            }

            Console.ReadKey();
        }
    }
}
