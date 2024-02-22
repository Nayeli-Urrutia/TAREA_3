using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 2

            int edad;
            Console.WriteLine("Ingrese su Edad");
            edad = int.Parse(Console.ReadLine());

            if ( edad >= 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Puede Ingresar al Club");
                Console.ResetColor();
            }    
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No puede Ingresar al Club");
                Console.ResetColor();

            }
            Console.ReadKey();
        }
    }
}
