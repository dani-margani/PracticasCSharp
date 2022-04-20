using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bools_PracticasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 10;

            //float numero2 = 10;
            //bool primeromayor = numero1 != numero2; //esto si es posible ya que se produce una conversion implicita.

            //int numero3 = 86;
            // bool primeromayor = numero1 != numero2 > numero3; esto no se puede hacer porque arroja un error, ya que primero se compara n3 con n2 y arroja el bool false.

            bool primeromayor = numero1 > numero2; // El > es un operador booleano que nos va a arrojar un valor true o false

            Console.WriteLine(primeromayor);
            Console.ReadLine();
        }
    }
}
