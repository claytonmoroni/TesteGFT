using System;

namespace TesteGFT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var anoAtual = 2021; 
            Console.WriteLine("Ola Bem Vindo  Insiro o ano que vc entrou:!");
            var anoEntrada = int.Parse(Console.ReadLine());

            var anosNaEmpresa = anoAtual - anoEntrada;

            if (anosNaEmpresa == 1)
            {
                Console.WriteLine("Vale Presente");
            }
            else if (anosNaEmpresa == 2)
            {
                Console.WriteLine("Smart Watch");
            }
            else if (anosNaEmpresa == 5)
            {
                Console.WriteLine("Fone Bluetooth");
            }
            else if (anosNaEmpresa == 10)
            {
                Console.WriteLine("Vale Jantar");
            }
            else if (anosNaEmpresa == 15)
            {
                Console.WriteLine("Vale Jantar Top");
            }
            else {
                Console.WriteLine("Esse ano não vai ter presente");
            }




        }
    }
}
