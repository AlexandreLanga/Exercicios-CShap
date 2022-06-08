using System;

namespace ExercicioFrota
{
    internal class Motoristas
    {
        public string CNH, nome, sobrenome;

        public string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }
    }
}
