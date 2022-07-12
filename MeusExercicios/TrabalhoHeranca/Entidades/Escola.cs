using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public abstract class Escola
    {
        public string Numero { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public double Salario { get; set; }

        public virtual string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

        public virtual double ObterPercentualReajuste(double percentual)
        {
            return percentual;
        }
    }
}
