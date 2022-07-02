using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Diretor : Funcionario
    {
        public string Area { get; set; }

        public Diretor(string numeroFuncionario) : base(numeroFuncionario)
        {
            System.Console.WriteLine("Construiu o diretor!");
        }

        public override string ObterProfissao()
        {
            return "Diretor";
        }
    }
}
