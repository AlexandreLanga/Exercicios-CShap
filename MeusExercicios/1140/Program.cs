using System;

namespace _1140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            char primL;

            while (true)
            {
                frase = Console.ReadLine();

                if (frase == "*")
                    break;

               var linha = frase.Split(' ');
                frase = frase.ToUpper();

                primL = frase[0];
                


               
            }
        }
    }
}
