using System;

namespace Página_110___Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int op;

            Console.Write("Ingrese un número del 1 al 7: ");
            valor = Console.ReadLine();
            op = Convert.ToInt32(valor);
            Console.Write("\n");

            switch (op)
            {
                case 1:
                    Console.WriteLine("El número ingresado corresponde al día domingo.");
                    break;
                case 2:
                    Console.WriteLine("El número ingresado corresponde al día lunes.");
                    break;
                case 3:
                    Console.WriteLine("El número ingresado corresponde al día martes.");
                    break;
                case 4:
                    Console.WriteLine("El número ingresado corresponde al día miércoles.");
                    break;
                case 5:
                    Console.WriteLine("El número ingresado corresponde al día jueves.");
                    break;
                case 6:
                    Console.WriteLine("El número ingresado corresponde al día viernes.");
                    break;
                case 7:
                    Console.WriteLine("El número ingresado corresponde al día sábado.");
                    break;
                default:
                    Console.WriteLine("El número ingresado se encuentra fuera del rando especificado.");
                    break;
            }
        }
    }
}
