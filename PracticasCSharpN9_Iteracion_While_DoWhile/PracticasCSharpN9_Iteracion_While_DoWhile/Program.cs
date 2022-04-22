using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN9_Iteracion_While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int cuenta = 10;

            while(cuenta > 0)
            {
                Console.WriteLine(cuenta);
                cuenta--;
            }

            Console.WriteLine("LANZAMIENTO");

            for(int cuenta2 =10; cuenta2 >0; cuenta2--)
            {
                Console.WriteLine(cuenta2);
            }

            Console.WriteLine("LANZAMIENTO");

            /*
             string respuesta;//SEGUNDA PARTE DEL EJERCICIO
              
             do 
            {
                Console.WriteLine("Introduzca SI o NO: ");
                respuesta = Console.ReadLine();
            } while (respuesta != "SI" && respuesta !="NO");

            if(respuesta=="SI")
            {
                Console.WriteLine("Has escrito SI");
            }

            else
            {
                Console.WriteLine("Has escrito NO");

            }*/



            /*int CuentaAtras = 10; //PRIMERA PARTE DEL EJERCICIO

            while(CuentaAtras > 0)
            {
                if(CuentaAtras == 7)
                {
                    CuentaAtras--;
                    continue;
                }
                Console.WriteLine("¡¡" + CuentaAtras + "!!");
                CuentaAtras--;
            }

            Console.WriteLine("¡¡Lanzamiento!!");*/

            Console.ReadKey();

        }
    }
}
