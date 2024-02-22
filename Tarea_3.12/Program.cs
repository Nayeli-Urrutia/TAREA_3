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
                case >= 89 and <= 100:
                    Console.WriteLine("Excelente");
                    break;
                case >= 80 and <= 88:
                    Console.WriteLine("Muy Bien");
                    break;
                case >= 69 and <= 79:
                    Console.WriteLine("Bueno");
                    break;
                case >= 60 and <= 68:
                    Console.WriteLine("Tiene que Mejorar");
                    break;

                case >= 50 and <= 59:
                    Console.WriteLine("Reprovado");
                    break;

                default:
                    Console.WriteLine("Calificacion No válida");
                    break;


            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
