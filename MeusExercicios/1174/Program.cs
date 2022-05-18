using System;

namespace _1174
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int[] A;
            A = new int[100];

            for (int i = 0; i <100; i++)
            {
                Double.TryParse(Console.ReadLine(), out valor);

                if (valor <=10.0)
                {
                    Console.WriteLine($"A[{i}] = {valor.ToString("F1")}");
                }
            }

        }
    }
}
