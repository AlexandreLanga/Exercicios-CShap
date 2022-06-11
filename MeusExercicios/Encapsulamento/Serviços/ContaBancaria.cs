using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.Serviços
{
    internal class ContaBancaria
    {
        #region Atributos
        private Entidades.ContaBancaria _contaBancaria;
        #endregion
        #region Construtores
        public ContaBancaria(Entidades.ContaBancaria contabancaria)
        {
            _contaBancaria = contabancaria;
        }
        #endregion
        #region Metodos Públicos
        public void Depositar(decimal valor)
        {
            _contaBancaria.Saldo += valor;
        }
        public decimal ObterSaldoAtual()
        {
            return _contaBancaria.Saldo;
        }
        public void Sacar(decimal valor)
        {
            _contaBancaria.Saldo -= valor;
        }
        #endregion
    }
}
