using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._11
{
    internal class Program
    {
        //PROGRAMA 11

        static void Main(string[] args)
        {
            string IDIOMA;

            Console.WriteLine(" Ingrese el idioma de su Preferencia:");
            Console.WriteLine(" Español");
            Console.WriteLine(" Inglés");
            Console.WriteLine(" Fránces");
            IDIOMA = Console.ReadLine();

            switch (IDIOMA)
            {
                case "Español":

                   Console.WriteLine("¡Estamos encantados de contar contigo aquí!");
                    break;

                case "Inglés":

                    Console.WriteLine("¡We are delighted to have you here!");
                    break;

                case "Fránces":

                    Console.WriteLine("¡Nous sommes ravis de vous avoir ici!");
                    break;

                default:

                    Console.WriteLine("Idioma no Disponible");
                    break;



            }
            Console.ReadKey();
        }
}
}
