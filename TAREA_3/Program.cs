using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // PROGRAMA 1
            double num1, num2, num3;

            try
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Escriba el primer número:");
                Console.ResetColor();
                num1 = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Escriba el segundo número:");
                num2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Escriba el tercer número:");
                num3 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                double mayor = Math.Max(num1, Math.Max(num2, num3));

                Console.WriteLine("El número mayor es: " + mayor);

                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.WriteLine(" ERROR");
            }
        }
    }
}

