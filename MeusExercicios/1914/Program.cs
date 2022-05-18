using System;

namespace _1914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jogados,impar,par, jogada1, jogada2;
            string somadasjogadas, jogada;

            int.TryParse(Console.ReadLine(), out jogados);

            for (int i = 0; i < jogados; i++)
            {
                
                jogada = Console.ReadLine();
                var vetorJogadas = jogada.Split(' ');

                int.TryParse(vetorJogadas[0], out jogada1);
                int.TryParse(vetorJogadas[1], out jogada2);

            }

        }
    }
}
