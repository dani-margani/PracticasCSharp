using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN7_ConjuncionYDisyuncionLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 25;
            int hermanos = 0;

            /*if(edad >= 18 && hermanos < 1)
            {
                Console.WriteLine("Es mayor de edad y no tiene hermanos");
            }
            Console.ReadKey(); 
            */
            if (edad >= 18 || hermanos < 1)
            {
                Console.WriteLine("Es mayor de edad Ó no tiene hermanos");
            }
            Console.ReadKey();

            /*if(edad >= 18) //Ejemplo
            {
                if (hermanos < 1)
                {
                    // Mayor de edad y no tiene hermanos
                }
            }*/
        }
    }
}
