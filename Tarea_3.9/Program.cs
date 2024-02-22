using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 9
            int semana;

            Console.WriteLine("Ingrese un Número del 1-7 para ver el día de la semana correspondiente");
            semana = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (semana )
            {
                case 1:
                    Console.WriteLine(" El día de la Semana es Lunes");
                    break;

                case 2:
                    Console.WriteLine(" El día de la Semana es Martes");
                    break;

                case 3:
                    Console.WriteLine(" El día de la Semana es Miercoles");
                    break;

                case 4:
                    Console.WriteLine(" El día de la Semana es Jueves");
                    break;

                case 5:
                    Console.WriteLine(" El día de la Semana es Viernes");
                    break;

                case 6:
                    Console.WriteLine(" El día de la Semana es Sabado");
                    break;

                case 7:
                    Console.WriteLine(" El día de la Semana es Domingo");
                    break;
                   
                default:

                    Console.WriteLine("Número no correspondiente a ningun Día de  la semana");
                    break;
            }
            Console.ResetColor();

            Console.ReadKey();

        }
    }
}
