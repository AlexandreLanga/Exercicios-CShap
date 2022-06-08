using System;

namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double total = a + b + c;
            total = total / 3;
            Console.WriteLine($"MEDIA = {total}");
        }
    }
}
