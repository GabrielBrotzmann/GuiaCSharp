using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.

            String frase;

            do
            {
                Console.WriteLine("Ingrese una frase, para finalizar, ingrese la frase (fin)  ");
                frase = Console.ReadLine();
            }
            while (frase != "fin");

            Console.WriteLine("El programa ha finalizado, presione enter para continuar");

            Console.ReadKey();


        }
    }
}
