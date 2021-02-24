using System;

namespace Página_110___Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string produc, valor;
            int prec;

            Console.WriteLine("---CALCULADORA DE PRECIOS---");
            Console.Write("\nCategoría del producto: ");
            produc = Console.ReadLine();

            Console.Write("Precio del producto: ");
            valor = Console.ReadLine();
            prec = Convert.ToInt32(valor);

            if (produc == "Medicina" || produc == "medicina")
            {
                Console.WriteLine("\nPrecio: " + prec);
                Console.WriteLine("Impuesto: 0");
                Console.WriteLine("Total: " + prec);
            } else
            {
                Console.WriteLine("\nPrecio: " + prec);
                Console.WriteLine("Impuesto: " + (prec*0.12));
                Console.WriteLine("Total: " + (prec+(prec*0.12)));
            }

        }
    }
}
