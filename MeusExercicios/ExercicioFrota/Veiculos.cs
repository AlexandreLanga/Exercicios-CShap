using System;

namespace ExercicioFrota
{
    internal class Veiculos
    {
        public string placa, marca, modelo;

        public string ObterDescrição(string placa, string modelo)
        {
            return modelo + "(" + placa + ")";
        }
    }
}
