using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PROGRAMA 8
            string palabra;

            Console.WriteLine("Ingrese un Número del 1-5 en letras");
            palabra = Console.ReadLine().ToLower();


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            switch (palabra)
            {
                case "uno":
                    Console.WriteLine(" El número ingresado es 1");
                    break;

                case "dos":
                    Console.WriteLine("El número ingresado es 2");
                    break;

                case "tres":
                    Console.WriteLine("El número ingresado es 3");
                    break;

                case "cuatro":
                    Console.WriteLine("El número ingresado es 4");
                    break;

                case "cinco":
                    Console.WriteLine(" El número ingresado es 5");
                    break;
                default:
                    Console.WriteLine("La letra ingresada no es un número del 1 al 5");
                    break;
            }
            Console.ResetColor();

                    Console.ReadKey();
            }
        }
    }

