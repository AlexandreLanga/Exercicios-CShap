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

        public void ImprimirFaixa()

            {
            if (idade >= 18)
                Console.WriteLine($"Maior de idade");
            else if (idade == 0)
                Console.WriteLine("Idade não informada");
            else
                Console.WriteLine($"De menor");
            }
          
    }
}
