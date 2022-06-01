using System;

namespace prototipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aqui cria as pessoas sem utilizar as classes
            CriarPessoasSemClasse();

            //Aqui cria as pessoas sem utilizar as classes
            CriarPessoasComClasse();

            //Aqui imprime a faixa etária
            

            Console.ReadKey();
        }
        static void CriarPessoasComClasse()
        {
            //Criando a pessoa um com classe
            Pessoa pessoaUm = new Pessoa();

            //Atribuindo valores para os atributos da pessoa um
            pessoaUm.nome = Console.ReadLine();
            pessoaUm.sobrenome = Console.ReadLine();
            pessoaUm.idade = int.Parse(Console.ReadLine());

            pessoaUm.ImprimirFaixa();

            //Chamando o método para exibir o nome completo da pessoa um
            pessoaUm.ExibirNomeCompleto();

            //pessoa cinco
            Pessoa pessoaDois = new Pessoa();
            pessoaDois.nome = Console.ReadLine();
            pessoaDois.sobrenome = Console.ReadLine();
            pessoaDois.ExibirNomeCompleto();

            pessoaDois.ImprimirFaixa();

            Console.ReadKey();
        }

        static void CriarPessoasSemClasse()
        {
            //Criando a pessoa um
            string nomePessoaUm = "Leonardo";
            string sobrenomePessoaUm = "Silva";
            int idadePessoaUm = 18;

            //Exibindo o nome completo da pessoa um
            Console.WriteLine($"{nomePessoaUm} {sobrenomePessoaUm}");
            //Exibindo a faixa de idade da pessoa um
            if (idadePessoaUm >= 18)
                Console.WriteLine($"Maior de idade");
            else
                Console.WriteLine($"De menor");

            //Criando a pessoa dois
            string nomePessoaDois = "José";
            string sobrenomePessoasDois = "Machado";
            long idadePessoaDois = 18;

            //Exibindo o nome completo da pessoa dois
            Console.WriteLine($"{nomePessoaDois} {sobrenomePessoasDois}");

            //Exibindo a faixa da pessoa dois
            if (idadePessoaDois > 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");

            //Criando a pessoa tres
            string nomePessoaTres = "Pedro";
            string sobrenomePessoaTres = "Soares";

            //Exibindo nome completo da pessoa três
            Console.WriteLine($"{nomePessoaTres} {sobrenomePessoaTres}");
            //Não contem faixa
        }
    }
}
