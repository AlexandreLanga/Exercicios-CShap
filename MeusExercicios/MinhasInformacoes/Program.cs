using System;

namespace MinhasInformacoes
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string nome;
            int idade;
            double altura;
            double peso;
            string linhaDigitada;

            linhaDigitada = Console.ReadLine();

            nome = Console.ReadLine();

            Console.WriteLine("Sua idade e:");
            int.TryParse(Console.ReadLine(), out idade);

            Console.WriteLine("Sua altura e");
            Double.TryParse(Console.ReadLine(), out altura);

            Console.WriteLine("Seu peso e:");
            Double.TryParse(Console.ReadLine(), out peso);

           
        }
    }
}
