using System;

namespace SeisNumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int.TryParse(Console.ReadLine(), out numero);
        
            for (int i = numero; i < numero + 12; i++)
            {
                if (i % 2 == 1)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
