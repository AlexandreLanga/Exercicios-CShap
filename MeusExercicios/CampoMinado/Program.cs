using System;

namespace CampoMinado
{
    internal class Program
    {
        static int[,] jogo;
        const int LINHAS = 9, COLUNAS = 9;

        static void Main(string[] args)
        {
            jogo = new int[LINHAS, COLUNAS];
            int contador = 0;
            int quemjoga = 1;
            bool continuarJogando = true;
            string posicaoJogada;

            while (continuarJogando)
            {
                ImprimirCampoMinado();
            }
        }

        static void ImprimirCampoMinado()
        {
            Console.WriteLine("Tabuleiro");
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    if (jogo[i, j] == 9)
                    {
                        Console.Write("   ");
                    }
                    else if (jogo[i, j] == 9)
                    {
                        Console.Write(" # ");
                    }
                    else if (jogo[i, j] == 9)
                    {
                        Console.Write(" # ");
                    }
                    if (j == 0 || j == 9)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i == 0 || i == 9)
                {
                    Console.WriteLine("---+---+---+---+---+---+---+---+---");
                }
            }
        }
    }
}
