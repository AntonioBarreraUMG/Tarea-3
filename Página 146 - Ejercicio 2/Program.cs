using System;

namespace Página_146___Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
			string valor;
			int num, pot, result = 1;

			Console.Write("Ingrese un número: ");
			valor = Console.ReadLine();
			num = Convert.ToInt32(valor);

			Console.Write("Ingrese la potencia: ");
			valor = Console.ReadLine();
			pot = Convert.ToInt32(valor);

			for (int i = 1; i <= pot; i++)
			{
				result *= num;
			}

			Console.WriteLine("\nEl resultado es: " + result);
		}
    }
}
