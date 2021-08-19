using System;
using System.Collections.Generic;
using System.Text;

namespace TesteGFT01
{
    public abstract class Idioma
    {
        public string nomeDoIdioma { get; set; }

        public virtual string  saudacao()
        {
            return "";
        }

    }
}
