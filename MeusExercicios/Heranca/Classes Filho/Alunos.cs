using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aluno : Pessoa
    {
        public string NumeroMatricula { get; set; }

        public decimal MediaNotas { get; set; }

        public Aluno()
        {
            System.Console.WriteLine("Construiu um aluno!");
        }

        public override string ObterProfissao()
        {
            return "Estudante";
        }
    }
}
