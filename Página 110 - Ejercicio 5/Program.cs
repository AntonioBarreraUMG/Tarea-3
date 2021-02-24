using System;

namespace Página_110___Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int op, cantLados, tamLados, anguloGrados, perímetro;
            double apotema, pi = Math.PI, anguloRadianes;

            Console.WriteLine("---Calculadora de polígonos regulares---");
            Console.WriteLine("Ingrese los datos del polígono...");
            Console.Write("\nCantidad de lados: ");
            valor = Console.ReadLine();
            cantLados = Convert.ToInt32(valor);

            Console.Write("Tamaño de los lados: ");
            valor = Console.ReadLine();
            tamLados = Convert.ToInt32(valor);

            Console.Write("\nIngrese el cálculo que desea realizar: \n<1> Perímetro. \n<2> Área. \nOpción: ");
            valor = Console.ReadLine();
            op = Convert.ToInt32(valor);

            perímetro = cantLados * tamLados;

            switch (op)
            {
                case 1: //Perímetro
                    Console.WriteLine("\nEl perímetro del polígono es: " + perímetro);
                break;

                case 2: //Área
                    anguloGrados = 360 / (2 * cantLados);
                    anguloRadianes = (anguloGrados * pi) / 180;
                    apotema = tamLados / (2 * Math.Tan(anguloRadianes));
                    Console.WriteLine("\nEl área del polígono es: " + (perímetro * apotema) / 2);
                    break;
                default:
                    Console.WriteLine("\nIngrese una opción válida.");
                    break;
            }
        }
    }
}
