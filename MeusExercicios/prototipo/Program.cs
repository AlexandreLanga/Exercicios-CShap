using System;

namespace prototipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pessoa Um
            string nomePessoaUm = Console.ReadLine();
            string sobrenomePessoaUm = Console.ReadLine();
            int idadePessoaUm = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nomePessoaUm} {sobrenomePessoaUm}");

            //pessoa dois
            string nomePessoaDois = Console.ReadLine();
            string sobrenomePessoasDois = Console.ReadLine();
            long idadePessoaDois = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nomePessoaDois}{sobrenomePessoasDois}");

            //pessoa tres
            string nomePessoaTres = Console.ReadLine();
            string sobrenomePessoaTres = Console.ReadLine();

            Console.WriteLine($"{nomePessoaTres}{sobrenomePessoaTres}");

            Console.ReadKey();
        }

    }
}
