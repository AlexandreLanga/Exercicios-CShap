using System;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i ++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
 
            }

        }
    }
}
