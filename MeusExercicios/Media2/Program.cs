using System;

namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pesoA = 2, pesoB = 3, pesoC = 5;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double total = (((a * pesoA) + (b * pesoB) + (c * pesoC)) / (pesoA + pesoB + pesoC));
            Console.WriteLine($"MEDIA = {total.ToString("F1")}");
        }
    }
}
