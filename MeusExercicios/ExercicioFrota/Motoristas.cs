using System;

namespace ExercicioFrota
{
    internal class Motoristas
    {
        public string CNH, nome, sobrenome;

        public void ObterNomeCompleto()
        {
            Console.WriteLine("Suas informações são:");
            Console.WriteLine($"Sua CNH é {CNH}");
            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Seu sobrenome é {sobrenome}");
        }
    }
}
