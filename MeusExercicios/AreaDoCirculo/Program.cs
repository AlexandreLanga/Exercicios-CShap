using System;

namespace AreaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            const double n = 3.14159;

            Double.TryParse(Console.ReadLine(), out raio);

            area = (n * (raio * raio));
            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
