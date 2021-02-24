using System;

namespace Página_110___Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            string valor;
            int op, num;

            Console.WriteLine("Elija el tipo de conversión: \n <1> Grados a radianes. \n <2> Radianes a grados.");
            Console.Write("Opción: ");
            valor = Console.ReadLine();
            op = Convert.ToInt32(valor);

            switch(op)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.Write("Ingrese la cantidad en grados: ");
                    valor = Console.ReadLine();
                    num = Convert.ToInt32(valor);
                    Console.WriteLine($"El resultado es {(num * pi) / 180} radianes.");
                    break;

                case 2:
                    Console.WriteLine("\n");
                    Console.Write("Ingrese la cantidad en radianes: ");
                    valor = Console.ReadLine();
                    num = Convert.ToInt32(valor);
                    Console.WriteLine($"El resultado es {(num * 180) / pi} grados.");
                    break;

                default:
                    Console.WriteLine("Elija una opción correcta.");
                    break;
            }
        }
    }
}
