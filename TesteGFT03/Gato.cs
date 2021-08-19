using System;
using System.Collections.Generic;
using System.Text;

namespace TesteGFT3
{
    public class Gato:Animal
    {
        public Gato(string nome, double peso) : base(nome, peso)
        {
        }

        public string som()
        {
            return "miau";
        }
        public double quantidadeDeRacao()
        {
            if (peso <= 4)
                return  peso * (0.012);
            else 
                return peso * (0.015);
        }
    }
}
