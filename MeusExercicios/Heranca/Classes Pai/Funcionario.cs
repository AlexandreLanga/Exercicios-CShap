using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class Funcionario : Pessoa
    {
        public string NumeroFuncionario { get; set; }

        public decimal Salario { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"{NumeroFuncionario} - {base.ObterNomeCompleto()}";
        }

        public Funcionario(string numeroFuncionario)
        {
            NumeroFuncionario = numeroFuncionario;
            System.Console.WriteLine("Construiu um funcionário com parâmetro!");
        }
    }
}
