using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Professor : Pessoa
    {
        public string NumeroFuncionario { get; set; }

        public decimal Salario { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"{NumeroFuncionario} - {Nome} {Sobrenome}";
        }
    }
}
