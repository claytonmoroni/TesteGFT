using System;

namespace TesteGFT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero inicial");
            var inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero final");
            var fim = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++)
            {
                if (i > 6)
                {
                    imprimir(i % 7);
                }
                else
                {
                    imprimir(i);
                }
            }

           

            


        }

        private static void imprimir(int i)
        {
            if (i == 0)
                Console.WriteLine("Dó");
            else if (i == 1)
                Console.WriteLine("Ré");
            else if (i == 2)
                Console.WriteLine("Mí");
            else if (i == 3)
                Console.WriteLine("Fá");
            else if (i == 4)
                Console.WriteLine("Sol");
            else if (i == 5)
                Console.WriteLine("Lá");
            else if (i == 6)
                Console.WriteLine("Si");
        }

    }
}
