using System;

namespace _1140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            char primeiraletra;

            while (true)
            {
                frase = frase.ToUpper();
                frase = Console.ReadLine().Split(' ')[0];

                if (frase == "*")
                break;

                primeiraletra = frase[0];

                if (true)
                    Console.WriteLine("Y");
                else if (false)
                    Console.WriteLine("N");
            }
        }
    }
}
