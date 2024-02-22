using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 10 

            string servicio;
            int lavado, cambio, revision;

            Console.WriteLine("Ingrese el Tipo de servicio que desea:");
            Console.WriteLine("Lavado de Auto");
            Console.WriteLine("Cambio de Aceite");
            Console.WriteLine("Revisión Mecánica");
            servicio = Console.ReadLine();
            lavado = 100;
            cambio = 50;
            revision = 200;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            switch (servicio)
            {
                case "Lavado de Auto":
                    Console.WriteLine("El importe a Pagar es de Q." + lavado);
                    break;
                case "Cambio de Aceite":
                    Console.WriteLine("El importe a Pagar es de Q." + cambio);
                    break;

                case "Revisión Mecanica":
                    Console.WriteLine("El importe a Pagar es de Q." + revision);
                    break;

                default:
                    Console.WriteLine("Este servicio no esta incluido");
                    break;
            }
            Console.ResetColor();
            Console.ReadKey();


            }
        }
    }

