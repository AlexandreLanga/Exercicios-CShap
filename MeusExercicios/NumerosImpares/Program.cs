using System;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Double.TryParse(Console.ReadLine(), out numero);

            for (numero = 1; numero <= 1000;numero ++)
            {
                if (numero % 2 == 1)
                {
                    Console.WriteLine(numero);
                }
 
            }

        }
    }
}
