using System;

namespace Página_146___Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 2, cont2 = 0;

            while (cont <= 1000)
            {
                cont2 = 0;

                for (int i = 2; i <= cont; i++)
                {
                    if (cont % i == 0)
                    {
                        cont2++;
                    }
                }

                if (cont2 < 2)
                {
                    Console.WriteLine(" " + cont);
                }

                cont++;
            }
        }
    }
}
