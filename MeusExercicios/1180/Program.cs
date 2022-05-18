using System;

namespace _1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorN, x, y = 1000, z;
            x = z = 0;

            int.TryParse(Console.ReadLine(), out valorN);

            int[] vetor = new int[valorN];

            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(linha[i]);

                if (vetor[i] < y)
                {
                    y = vetor[i];
                    z = i;
                }
            }

            Console.WriteLine($"Menor valor: {y}");
            Console.WriteLine($"Posicao: {z}");

        }
    }
}
