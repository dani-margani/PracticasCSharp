using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasCSharpN6_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");

            int opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            if(opcionSeleccionada != 1)
            {
                if (opcionSeleccionada != 2)
                {
                    Console.WriteLine("Opcion Incorrecta");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("Introduzca el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            /*
            switch (opcionSeleccionada)
            {
                case (1):
                    int suma = num1 + num2;
                    Console.WriteLine("La suma es " + suma);
                    break;
                case (2):
                    int resta = num1 + num2;
                    Console.WriteLine("La resta es " + resta);
                    break;
              
            }
            */



            /*int opcion = 3;

            switch(opcion)
           {
                case (1):
                    Console.WriteLine("La variable es 1");
                    break; //indica que hemos terminado de dar instrucciones
                case (2):
                    Console.WriteLine("La variable es 2");
                    break;
                case (3):
                    Console.WriteLine("La variabe es 3");
                    break;

           }*/

            if (opcionSeleccionada == 1)
            { 
                int suma = num1 + num2;
            Console.WriteLine("La suma es " + suma);

            }
            else if (opcionSeleccionada ==2)
            {
                int resta = num1 - num2;
                Console.WriteLine("La resta es " + resta);
            }

            Console.ReadKey();

        }
    }
}
