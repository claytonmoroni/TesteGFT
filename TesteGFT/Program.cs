using System;
using TesteGFT01;

namespace TesteGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Portugues portugues = new Portugues();
            portugues.nomeDoIdioma = "Português";
            Console.WriteLine(portugues.saudacao());

            Ingles ingles = new Ingles();
            portugues.nomeDoIdioma = "Inglês";
            Console.WriteLine(ingles.saudacao());

            Hungaro hungaro = new Hungaro();
            portugues.nomeDoIdioma = "Húngaro";
            Console.WriteLine(hungaro.saudacao());

            Tcheco tcheco = new Tcheco();
            portugues.nomeDoIdioma = "Tcheco";
            Console.WriteLine(tcheco.saudacao());

        }
    }
}
