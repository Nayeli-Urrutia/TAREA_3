using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 5
            int numero;          

            Console.WriteLine("Ingrese un Número Entero");
            numero = int.Parse(Console.ReadLine());
   

            if (numero % 2==0 )
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("El Número Ingresado es Par");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("El Número Ingresado es Impar");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
