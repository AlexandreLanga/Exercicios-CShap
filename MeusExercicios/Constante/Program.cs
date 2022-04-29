using System;

namespace Constante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escrever um programa que 
             * vai ler  3 notas de prova
             * sendo que
             * a primeira prova tem peso de 30%
             * a segunda prova tem peso de 50%
             * a terceira prova tem peso de 20%
             * ao final, imprimir a média
             * e dizer se o aluno foi aprovado
             * ou não
             */
            double prova1, prova2, prova3, media;
            const double prova30 = 30, prova50 = 50, prova20 = 20;

            Console.WriteLine("Digite a sua primeira prova");
            Double.TryParse(Console.ReadLine(), out prova1);

            Console.WriteLine("Digite a sua segunda prova");
            Double.TryParse(Console.ReadLine(), out prova2);

            Console.WriteLine("Digite a sua terceira prova");
            Double.TryParse(Console.ReadLine(), out prova3);

            media = (prova1 * prova30) / 100;
            media = media + ((prova2 * prova50) / 100);
            media = media + ((prova3 * prova20) / 100);

            Console.WriteLine("Sua média e");
            Console.WriteLine(media);

            if (media >= 7)
            {
                Console.WriteLine("Parabens! Você foi aprovado");
            }

            else
            {
                Console.WriteLine("Infelizmente você foi reprovado");
            }
        }
    }
}
