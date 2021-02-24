using System;

namespace Página_146___Ejercicio_1
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

			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine($"{num} x {i} = " + (num * i));
			}
		}
    }
}
