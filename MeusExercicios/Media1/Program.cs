using System;

namespace Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double A1 = 3.5, B1 = 7.5;
            double A, B, MEDIA;
            

            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);

            MEDIA = ((A1 * A) + (B1 * B))/(A1 + B1);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
            

        }
    }
}
