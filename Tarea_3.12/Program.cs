using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            double zona;
            Console.WriteLine("Ingrese la Nota de su Zona 0-65");
            zona = double.Parse(Console.ReadLine());

            if (zona is int)
            {
                Console.WriteLine("El número es entero");
            }
            else
            {
                Console.WriteLine("El número no es entero");
            }


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            switch (zona)
                    {
                        case >= 30 and <= 65:
                            Console.WriteLine("Excelente");
                            break;
                        case >= 0 and <= 26:
                            Console.WriteLine("No llego a Zona Minima");
                            break;

                        default:
                            Console.WriteLine("Calificacion No válida");
                            break;
                    }
            Console.ResetColor();
                
            Console.WriteLine("Ingrese la Nota de su Examen Final de 0-35");
            calificacion = double.Parse(Console.ReadLine());

            if (calificacion is int)
            {
                Console.WriteLine("El número es entero");
            }
            else
            {
                Console.WriteLine("El número no es entero");
            }

            switch (calificacion)
                    {
                        case >= 30 and <= 35:
                            Console.WriteLine("Excelente");
                            break;
                        case >= 20 and <= 29:
                            Console.WriteLine("Muy Bien");
                            break;
                        case >= 10 and <= 19:
                            Console.WriteLine("Bueno");
                            break;
                        case >= 0 and <= 9:
                            Console.WriteLine("Tiene que Mejorar");
                            break;

                        default:
                            Console.WriteLine("Calificacion No válida");
                            break;
                    }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            double final = zona + calificacion;

            if (final> 61)
            {
                Console.WriteLine("Esta Aprobado!");
            }
            else
            {
                Console.WriteLine("Ha Reprobado");
            }
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
