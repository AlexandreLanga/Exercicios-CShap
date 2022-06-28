using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Pessoa
    {
        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public virtual string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
