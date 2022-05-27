using System;

namespace Intervalo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorN, valorX, valorIn = 0, valorOut = 0;

            int.TryParse(Console.ReadLine(), out valorN);

            for (int i = 0; i < valorN; i++)
            {
                int.TryParse(Console.ReadLine(), out valorX);

                if (10 <= valorX && valorX <= 20)
                {
                    valorIn++;
                }

                else
                {
                    valorOut++;
                }
            }

            Console.WriteLine(valorIn + " in");
            Console.WriteLine(valorOut + " out");
        }
    }
}
