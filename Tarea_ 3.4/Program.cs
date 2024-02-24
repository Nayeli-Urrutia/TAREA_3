using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA 4 
            try { 
            String Nombre, Contraseña;
            bool permitido = false;
            Console.WriteLine(" Ingrese su Nombre de Usuario ");
            Nombre = Console.ReadLine();

            Console.WriteLine(" Ingrese su Contraseña ");
            Contraseña = Console.ReadLine();

            if (Nombre == "Nayeli_Urrutia"  && Contraseña== "Hola")
            {
                permitido = true;

            }
            if (permitido)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("¡BIENVENIDA NAYELI!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Usuario o Contraseña Incorrecta");
                Console.ResetColor();
            }
           
            }
            catch (FormatException)
            {
                Console.WriteLine(" ERROR");
            }

            Console.ReadKey();
        }
    }
}
