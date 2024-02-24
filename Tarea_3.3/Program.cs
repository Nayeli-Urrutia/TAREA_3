using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PROGRAMA 3 
            try { 

            double precio, descuento, preciof ;
            Console.WriteLine("Ingrese el Precio del Producto");
            precio = double.Parse(Console.ReadLine());

            descuento = (precio * 10) / 100;
            preciof = precio - descuento;

            if (precio > 100)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" El precio del Producto con el descuento de 10% es de: Q." + preciof);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("No se cuenta con descuento");
                Console.WriteLine("El precio final es de: Q." + precio  );
                Console.ResetColor();
            }

            }
            catch (FormatException)
            {
                Console.WriteLine(" ERROR");
            }

            Console.ReadKey();

        }
    }
}
