using System;
using TesteGFT3;

namespace TesteGFT03
{
    class Program
    {
        static void Main(string[] args)
        {
            var gataum = new Gato("Coca",20);
            var gatadois = new Gato("Foxy", 3);

            var cachorroum = new Cachorro("Einstein", 10);
            var cachorrodois = new Cachorro("Edward", 5);

            var somaRacao = gataum.quantidadeDeRacao() + gatadois.quantidadeDeRacao() + cachorroum.quantidadeDeRacao() + cachorrodois.quantidadeDeRacao();

            Console.WriteLine("total de racao =" + somaRacao);


        }
    }
}
