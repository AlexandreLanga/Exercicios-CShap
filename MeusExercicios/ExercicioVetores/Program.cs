using System;

namespace ExercicioVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* FAÇA UM PROGRAMA QUE LEIA 
             * UM NUMERO X
             * E NA SEQUÊNCIA LEIA X VALORES
             * DEPOIS, IMPRIMA, DE TRAZ PARA
             * FRENTE OS VALORES LIDOS*/

            int x, y;
            int[] xvalores;

            int.TryParse(Console.ReadLine(), out x);
            xvalores = new int[x];

            for (int i = 0; i < x; i++)
            {
               int.TryParse(Console.ReadLine(), out y);
                xvalores[i] = y;
            }
            for (int i = x-1; i >= 0; i--)
            {
                Console.WriteLine(xvalores[i]);
            }
        }
    }
}
