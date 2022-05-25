using System;

namespace _1103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, h2, m2;
            string numeros;

            numeros = Console.ReadLine();
            var vetorNumeros = numeros.Split(' ');

            int.TryParse(vetorNumeros[0], out h1);
            int.TryParse(vetorNumeros[1], out m1);
            int.TryParse(vetorNumeros[2], out h2);
            int.TryParse(vetorNumeros[3], out m2);


        }
    }
}
