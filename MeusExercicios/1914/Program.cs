using System;

namespace _1914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jogados, nome1, nome2, soma, valor1, valor2;
            string jogada, valores;

            int.TryParse(Console.ReadLine(), out jogados);

            for (int i = 0; i < jogados; i++)
            {
              
                jogada = Console.ReadLine();
                var vetorJogada = jogada.Split(' ');

                int.TryParse(vetorJogada[0], out nome1);
                int.TryParse(vetorJogada[2], out nome2);

                valores = Console.ReadLine();
                var vetorValores = valores.Split(' ');

                int.TryParse(vetorValores[0], out valor1);
                int.TryParse(vetorValores[1], out valor2);

                soma = valor1 + valor2;

                if (soma %2 == 0)
                {
                    if (vetorJogada[1] == "PAR")
                    {
                        Console.WriteLine($"{vetorJogada[0]}");
                    }
                    else if (vetorJogada[3] == "PAR")
                    {
                        Console.WriteLine($"{vetorJogada[2]}");
                    }
                    
                }
                else if (soma %2 == 1)
                {
                    if (vetorJogada[1] == "IMPAR")
                    {
                        Console.WriteLine($"{vetorJogada[0]}");
                    }
                    else if (vetorJogada[3] == "IMPAR")
                    {
                        Console.WriteLine($"{vetorJogada[2]}");
                    }

                }
            }
        }
    }
}
