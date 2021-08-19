using System;
using System.Collections.Generic;
using System.Text;

namespace TesteGFT3
{
    public abstract class  Animal
    {
        protected Animal(string nome, double peso)
        {
            this.nome = nome;
            this.peso = peso;
        }

        public string nome { get; set; }

        public double peso { get; set; }

        public string som()
        {
            return "";
        }

        public double quantidadeDeRacao()
        {
            return 0;
        }

    }
}
