using System;

namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (num = 1; num <= 100; num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
