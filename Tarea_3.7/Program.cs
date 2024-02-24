using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 7
            try { 
            string tipoFigura;
            double areat, areac, areag ;

            Console.WriteLine ("Introduzca el tipo de figura geométrica para encontrar su Aréa");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine ("(triángulo, cuadrado o círculo): ");
            Console.ResetColor();
            tipoFigura = Console.ReadLine();

            if (tipoFigura == "triángulo")
            {
                double baseTriangulo, alturaTriangulo;

                Console.WriteLine("Introduzca la base del triángulo: ");
                baseTriangulo = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca la altura del triángulo: ");
                alturaTriangulo = double.Parse(Console.ReadLine());

                areat = (baseTriangulo * alturaTriangulo) / 2;

                Console.WriteLine("El Aréa del Triangulo es de: " + areat );
                
            }
            else if (tipoFigura == "cuadrado")
            {
                double ladoCuadrado, ladoCuadradoa;

                Console.WriteLine("Introduzca el lado  A del cuadrado: ");
                ladoCuadradoa = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el lado B del cuadrado: ");
                ladoCuadrado = double.Parse(Console.ReadLine());

                areac = ladoCuadradoa * ladoCuadrado;

                Console.WriteLine("El Aréa del Cuadrado es de: " + areac );
               
            }
            else if (tipoFigura == "círculo")
            {
                double radioCirculo;

                Console.WriteLine("Introduzca el radio del círculo: ");
                radioCirculo = double.Parse(Console.ReadLine());

                areag = Math.PI * radioCirculo * radioCirculo;

                Console.WriteLine("El Aréa del Circulo es de: " + areag);
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Tipo de figura geométrica no válida.");
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
