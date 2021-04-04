using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo tecla;

            Console.WriteLine("Presione una tecla cualquiera, el programa finaliza cuando presione X");
            do {
                tecla = Console.ReadKey(true);

                Console.WriteLine("Usted presionó la tecla " + tecla.Key);       
            }
            while (tecla.Key.ToString() != "X");

            Console.WriteLine("Presione cualquier tecla para finalizar");

            Console.ReadKey();
        }
    }
}
