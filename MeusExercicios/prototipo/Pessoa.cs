using System;

namespace prototipo
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        
        public void ExibirNomeCompleto()
        {
            Console.WriteLine($"{nome} {sobrenome}");
        }
    }
}
