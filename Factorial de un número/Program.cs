using System;

namespace Factorial_de_un_número
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

            Console.Write("\n" + num);

            for (int i = (num - 1); i >= 1; i--)
            {
                Console.Write($" X {i}");
            }

            for (int i = (num-1); i >= 1; i--)
            {
                num *= i;
            }

            Console.WriteLine(" = " + num);
        }
    }
}
