using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Professor : Funcionario, IPessoa
    {
        public string Curso { get; set; }

        public override string ObterProfissao()
        {
            return "Professor";
        }

        public Professor(string numeroFuncionario) : base (numeroFuncionario)
        {
            System.Console.WriteLine("Construiu o professor!");
        }

        public string ObterNomeComProfissao()
        {
            return $"{Nome} - {ObterProfissao()}";
        }
    }
}
