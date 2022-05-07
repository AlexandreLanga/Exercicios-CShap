using System;

namespace PIPN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, pares = 0, impares = 0, positivos = 0, negativos = 0;

            for (int i = 1; i <= 5; i++)
            {
                Double.TryParse(Console.ReadLine(), out num);

                if (num % 2 == 0)
                {
                    pares++;
                }

                else
                {
                    impares++;
                }

                if (num > 0)
                {
                    positivos++;
                }

                else if (num < 0)
                {
                    negativos++;
                }
            }
                Console.WriteLine(pares + " valor(es) par(es)");
                Console.WriteLine(impares + " valor(es) impar(es)");
                Console.WriteLine(positivos + " valor(es) positivo(s)");
                Console.WriteLine(negativos + " valores negativos");
            
        }
    }
}
