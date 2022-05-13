using System;

namespace PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, primeiro = 1;

            int.TryParse(Console.ReadLine(), out N);

            for ( int i = 0; i < N; i++)
            {
                int segundo = primeiro + 1;
                int terceiro = primeiro + 2;

                Console.WriteLine($"{primeiro} {segundo} {terceiro} PUM");
                primeiro += 4;
            }
        }
    }
}
