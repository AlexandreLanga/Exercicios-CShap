using System;

namespace PositivosEMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, media = 0, valortotal = 0;
            int positivos = 0;

            //for ( 1 ; 2 ; 3)
            //{
            //}

            // 1 - só vez e no inicio do for
            // 2 - sempre executa para testar
            // 3 - executa sempre no final do laço

            // 1 -> 2
            // 2 -> executa o código
            // 3 -> 2

            for (int i = 1; i <= 6; i++)
            {
                Double.TryParse(Console.ReadLine(), out num);

                if (num > 0)
                {
                    //positivos++;
                    positivos = positivos + 1;
                    valortotal = valortotal + num;
                    media = valortotal / positivos;
                }

            }

            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1"));

      
         }
    }
}
