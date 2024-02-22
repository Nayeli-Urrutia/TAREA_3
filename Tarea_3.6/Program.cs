using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 6

            double prestamo;
            int edad;
            bool aceptar = false;

            Console.WriteLine(" Ingrese el Monto del Prestamo que Solicitara");
            prestamo = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (prestamo < 5000 & edad > 60)
            {
                aceptar = true;
            }

            if (aceptar)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Su Prestamo ha sido Aprovado");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Su Prestamo ha sido Rechazado");
                Console.ResetColor();
            }
            Console.ReadKey();

        }
    }
}
