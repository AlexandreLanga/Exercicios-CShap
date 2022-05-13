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
            int contador = 0; 
            int quemjoga = 1;
            bool continuarJogando = true;
            bool checarGanhador, checarEmpate;
            string posicaoJogada;

            while (continuarJogando) //laço do jogo
            {

                // imprimir tabuleiro
                ImprimirTabuleiro();
                // ler quem joga
                posicaoJogada = LerPosicaoJogador(quemjoga);

                // registrar posição de jogada
                RegistrarPosicaoJogador(quemjoga, posicaoJogada);

                // checar se ganhou
                checarGanhador = ChecarGanhador(quemjoga);

                // checar empate
                if (checarGanhador == false)
                {
                    checarEmpate = ChecarEmpate();
                    if (checarEmpate == true)
                    {
                        Console.WriteLine("Houve empate!");
                        continuarJogando = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Jogador {quemjoga} é o vencedor!");
                    continuarJogando = false;
                }


                // alterar quem joga
                if(quemjoga == 1)
                {
                    quemjoga = 2;
                }
                else if (quemjoga == 2)
                {
                    quemjoga = 1;
                }


               // continuarJogando = false;
            }
            ImprimirTabuleiro();
        }

        static bool ChecarEmpate()
        {
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    if (jogo[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool ChecarGanhador(int quemjoga)
        {
            if (jogo[0,0] == quemjoga && jogo[0,1] == quemjoga && jogo[0,2] == quemjoga)
            {
                return true;
            }
            else if (jogo[1, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[1, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[2, 0] == quemjoga && jogo[2, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 0] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 1] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 1] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 2] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 2] == quemjoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemjoga && jogo[1, 1] == quemjoga && jogo[2, 0] == quemjoga)
            {
                return true;
            }

            return false;
        }

        static void RegistrarPosicaoJogador( int quemjoga, string posicaoJogada)
        {
            int x, y;
            var posicoes = posicaoJogada.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            jogo[x, y] = quemjoga;
        }

        static string LerPosicaoJogador(int quemJoga)
        {
            Console.WriteLine($"Jogador {quemJoga} é a sua vez! Escolha uma posição");
            string linha;
            int x, y;
            /*
             * 0 0 | 0 1 | 0 2
             * 1 0 | 1 1 | 1 2
             * 2 0 | 2 1 | 2 2
             */
            linha = Console.ReadLine(); // 0 2
            var posicoes = linha.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            if (jogo[x, y] == 0)
            {
                // posição não jogada
                return linha;
            }

            return "";
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
                    if (j == 0 || j == 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("---+---+---");
                }
            }

        }

    }
}
