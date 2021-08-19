using System;
using System.Collections.Generic;
using System.Text;

namespace TesteGFT3
{
    public class Cachorro:Animal
    {
        public Cachorro(string nome, double peso) : base(nome, peso)
        {
        }

        public string som()
        {

            return "auau";
        }
        public double quantidadeDeRacao()
        {
            if (peso <= 3)
                return  peso * (0.035);
            else if(peso > 3&& peso <=10)
                return peso * (0.045);
            else 
                return peso * (0.050);
        }
    }
}
