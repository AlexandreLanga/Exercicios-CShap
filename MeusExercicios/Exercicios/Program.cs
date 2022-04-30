using System;

    
namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("X = " + (a + b));
        }
    }
}
