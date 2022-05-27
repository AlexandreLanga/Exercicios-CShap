using System;

namespace NumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            int positivos = 0;



            for (int i = 1; i <= 6; i++)
            {
                Double.TryParse(Console.ReadLine(), out num);

                if (num > 0)
                {
                    positivos++;
                }
            }
                Console.WriteLine(positivos + " valores positivos");
           
        }
    }
}
