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
                    Console.WriteLine("Excelente");
                    break;
                case >= 79 and <= 89:
                    Console.WriteLine("Muy bien ");
                    break;
                case >= 69 and <= 78:
                    Console.WriteLine("Bien");
                    break;
                case >= 60 and <= 68:
                    Console.WriteLine("Tiene que Mejorar");
                    break;

                case >= 50 and <= 59:
                    Console.WriteLine("Reprovado");
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
