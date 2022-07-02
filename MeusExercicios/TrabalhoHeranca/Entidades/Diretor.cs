using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Diretor : Funcionario
    {
        public override string ObterNomeCompleto()
        {
            return $"O nome de seu diretor atual é : {base.ObterNomeCompleto()}";
        }

    }
}
