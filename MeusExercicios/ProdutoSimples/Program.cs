using System;

namespace ProdutoSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Double.TryParse(Console.ReadLine(), out a);
            Double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("PROD = " + (a * b));
        }
    }
}
