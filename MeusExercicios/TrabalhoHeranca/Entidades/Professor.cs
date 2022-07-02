using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Professor : Funcionario
    {
        public string Curso { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"O nome de seu professor atual é: {base.ObterNomeCompleto()}";
        }
    }
}
