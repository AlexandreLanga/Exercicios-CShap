using System;

namespace _1168
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, indice;
            int[] leds = new int[10] { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
            string num;

            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                var soma = 0;
                num = Console.ReadLine();

                for (int s = 0; s < num.Length; s++)
                {
                    int.TryParse(num[s].ToString(), out indice);
                    soma = soma + leds[indice];
                }
                Console.WriteLine($"{soma} leds");
            }
        }
    }
}
