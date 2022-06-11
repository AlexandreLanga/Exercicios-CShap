using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.Entidades
{
    public class Pessoa
    {
        #region Propriedades
        public string CPF { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        #endregion Propriedades

        #region Metodos Públicos
        public string ObterNomeCompleto()
        {
            return $"{nome} {sobrenome}";
        }
        #endregion Metodos Públicos
    }
}
