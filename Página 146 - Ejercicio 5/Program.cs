using System;

namespace Página_146___Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int cant, edad, suma = 0, mayor = 0, menor = 200, cont = 1;

            Console.Write("Ingrese la cantidad de personas: ");
            valor = Console.ReadLine();
            cant = Convert.ToInt32(valor);
            
            Console.Write("\n");

            while (cont <= cant)
            {
                Console.Write($"Edad de persona {cont}: ");
                valor = Console.ReadLine();
                edad = Convert.ToInt32(valor);

                if (edad > mayor)
                {
                    mayor = edad;
                }

                if (edad < menor)
                {
                    menor = edad;
                }

                suma += edad;

                cont++;
            }

            Console.WriteLine("\nPromedio de edad: " + (suma / cant));
            Console.WriteLine("Edad mayor: " + mayor);
            Console.WriteLine("Edad menor: " + menor);
        }
    }
}
