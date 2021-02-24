using System;

namespace Página_110___Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int num;
            Console.Write("Ingrese un número: ");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            if (num%2 == 0)
            {
                Console.WriteLine($"El número {num} es par.");
            } else
            {
                Console.WriteLine($"El número {num} es impar.");
            }
        }
    }
}
