using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Veiculo
    {
        public int VelocidadeAtual { get; set; }

        private bool CarroLigando;

        private void FreiarVeiculo()
        {
           VelocidadeAtual = 0;
        }
            
        public void LigarVeiculo()
        {
            CarroLigando = true;
        }

        public void DesligarVeiculo()
        {
            if (VelocidadeAtual == 0)
            {
                FreiarVeiculo();
                CarroLigando = false;
            }
        }

        public bool VeiculoEsta()
        {
            return CarroLigando;
        }

        public int AcelerarVeiculo(int acelerar)
        {
            if (VelocidadeAtual <= 100)
            {
                VelocidadeAtual = acelerar;
            }
            return VelocidadeAtual;
        }
    }
}
