using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN8_Iteracion_for_break_continue
{
    class Program
    {
        static void Main(string[] args)
        { 
            int tabladel7 = 7;

            for (int elmultiplicador = 0; elmultiplicador <10; elmultiplicador++ )
            {
                if(elmultiplicador == 5)
                {
                    //break; 
                    continue;
                }
                Console.WriteLine(tabladel7 + " x " + elmultiplicador + " = " + tabladel7 * elmultiplicador);
            }

            Console.ReadKey();
        }
    }
} 
