using System;

namespace _1175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetores = new int[20];
            int valor = 0;

            for (int i = 0; i < vetores.Length; i++)
            {
                vetores[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(vetores);
            foreach (int n in vetores)
            {
                Console.WriteLine($"N[{valor}] = {n}");
                valor++;
            }
        }
    }
}
