using System;

namespace Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, numeros = 0, primos = 0;

            int.TryParse(Console.ReadLine(), out linhas);

            for (int i = 1; i <= linhas; i++)
            {
                numeros = int.Parse(Console.ReadLine());
                primos = 0;

                for(int j = 1; j < numeros; j++)
                {
                    if (numeros % j == 0)
                    {
                        primos += j;
                    }
                }

                if (primos == 1)
                {
                    Console.WriteLine($"{numeros} eh primo");
                }
                else
                {
                    Console.WriteLine($"{numeros} nao eh primo");
                }
            }
        }
    }
}
