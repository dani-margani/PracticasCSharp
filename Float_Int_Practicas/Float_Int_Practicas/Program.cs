using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Int_Practicas //Numeros Decimales de precision simple, precision aprox 9 a 10 digitos. Se representa el numero con una f al final ej. 1.5f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            string saludo = "Hola, ";

           // string nombre = "Daniela";

            string saludocompleto = saludo + nombre;

            Console.WriteLine(saludocompleto); 
            Console.ReadKey();


            /*float numeroentero1 = 10f;
             float numeroentero2 = 3f;

             float resultado = numeroentero1 / numeroentero2;
             Console.WriteLine(resultado);

             // float numerodecimal1 = 10f; //podemos meter un entero dentro de un decimal xq hace una conversion, si le ponemos la f al final no se convertirá.
             // float numerodecimal2 = 3f; //Tarda mas el ordenador en hacer una operacion en decimales
            // Console.WriteLine(numerodecimal1 / numerodecimal2);


             double dnumeroentero1 = 10.0;
             double dnumeroentero2 = 3.0; //el valor double debe llevar .0 al final para que nos arroje un resultado con decimales.

             double dresultado = dnumeroentero1 / dnumeroentero2;

             Console.WriteLine(dresultado);*/


        }
    }
}
