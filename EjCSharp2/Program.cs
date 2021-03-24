using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCSharp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto por teclado, luego presione enter para finalizar");

            string texto = Console.ReadLine();

            Console.WriteLine(texto);

            Console.ReadKey();

        }
    }
}
