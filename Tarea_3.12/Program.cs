using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 12
 
            double calificacion;

            Console.WriteLine("Ingrese la Nota de su Examen");
            calificacion = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (calificacion)
            {
                case >= 90 and <= 100:
                    Console.WriteLine("Sobresaliente");
                    break;
                case >= 80 and <= 89:
                    Console.WriteLine("Notable");
                    break;
                case >= 70 and <= 79:
                    Console.WriteLine("Aprobatoria");
                    break;
                case >= 60 and <= 69:
                    Console.WriteLine("No Aprobatoria");
                    break;

                default:
                    Console.WriteLine("Calificacion No Válida");
                    break;


            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
