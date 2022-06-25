using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Veiculo
    {
        public int VelocidadeAtual { get; set; }

        private bool _CarroLigando;

        private void FreiarVeiculo()
        {
           VelocidadeAtual = 0;
        }
            
        public void LigarVeiculo()
        {
            _CarroLigando = true;
        }

        public void DesligarVeiculo()
        {
            if (VelocidadeAtual > 0)
                FreiarVeiculo();

            _CarroLigando = false;
        }

        public bool VeiculoEsta()
        {
            return _CarroLigando;
        }

        public void AcelerarVeiculo(int acelerar)
        {
            if (_CarroLigando && (VelocidadeAtual <= 100))
            {
                VelocidadeAtual = acelerar;
            }
        }
    }
}
