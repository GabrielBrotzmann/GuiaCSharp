using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //6.Lea las teclas presionadas y finalice al presionar Shift+Ctrl + F.

            ConsoleKeyInfo tecla;
            String salida = "";

            Console.WriteLine("Presione una tecla cualquiera, el programa finaliza cuando presione Ctrl+S");
            do
            {
                salida = "";
                tecla = Console.ReadKey(true);
                if ((tecla.Modifiers & ConsoleModifiers.Alt) != 0) salida = salida + ("ALT+");
                if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0) salida = salida + ("SHIFT+");
                if ((tecla.Modifiers & ConsoleModifiers.Control) != 0) salida = salida + ("CTRL+");

                salida = salida + tecla.Key.ToString().ToUpper();

                Console.WriteLine("Usted presionó la tecla " + salida);
            }
            while (salida != "CTRL+S");
            
            Console.WriteLine("Presione cualquier tecla para finalizar");

            Console.ReadKey();
        }
    }
}
