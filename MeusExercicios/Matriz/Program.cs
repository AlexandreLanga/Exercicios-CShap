using System;

namespace Matriz
{
    internal class Program
    {
        static int[,] jogo;
        const int LINHAS = 3, COLUNAS = 3;
        static void Main(string[] args)
        {
            
            jogo = new int[LINHAS, COLUNAS];
            IniciarTabuleiro();

            int quemjoga = 0;
            bool continuarJogando = true;

            while (continuarJogando) //laço do jogo
            {

                // imprimir tabuleiro
                ImprimirTabuleiro();
                // ler quem joga
                // registrar posição de jogada
                // checar se ganhou
                // checar empate
                // alterar quem joga
                continuarJogando = false;
            }

            static void IniciarTabuleiro()
            {
                for (int i = 0; i < LINHAS; i++)
                {
                    for (int j = 0; j < COLUNAS; j++)
                    {
                        jogo[i, j] = 0;
                    }
                }
            }
            static void ImprimirTabuleiro()
            {
                Console.WriteLine("Tabuleiro");
                for (int i = 0; i < LINHAS; i++)
                {
                    for (int j = 0; j < COLUNAS; j++)
                    {
                        if (jogo[i, j] == 0)
                        {
                            Console.Write("   ");
                        }
                        else if (jogo[i, j] == 1)
                        {
                            Console.Write(" X ");
                        }
                        else if (jogo[i, j] == 2)
                        {
                            Console.Write(" O ");
                        }
                        if (j ==0 || j == 1)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                    if (i ==0 || i == 1)
                    {
                        Console.WriteLine("---+---+---");
                    }
                }

            }
        }
    }
}
