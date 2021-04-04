using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.	Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la palabra “fin”.

            String frase;
            String fin = "fin";

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            if (frase.ToUpper().Contains(fin.ToUpper()))
            {
                Console.WriteLine("La frase contiene la palabra fin");
            }
            else { Console.WriteLine("La frase no contiene la palabra fin"); }

            Console.WriteLine("Presione cualquier tecla para finalizar");

            Console.ReadKey();
        }
    }
}
