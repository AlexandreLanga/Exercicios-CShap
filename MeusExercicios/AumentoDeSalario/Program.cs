using System;

namespace AumentoDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Salário	Percentual de Reajuste
            0 - 400.00 15%
            400.01 - 800.00 12%
            800.01 - 1200.00 10%
            1200.01 - 2000.00 7%
            Acima de 2000.00 4%*/

            double salario, reajuste;
            int percentual;
            const double aumento1 = 15, aumento2 = 12, aumento3 = 10, aumento4 = 7, aumento5 = 4;

            reajuste = 0;


            Console.WriteLine("Digite seu salário:");
            Double.TryParse(Console.ReadLine(), out salario);

            if (0 <= salario && salario <= 400)
            {
                reajuste = (((salario * aumento1) / 100) + salario);
                percentual = 15;

                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste);
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
            }

            else if (400.01 <= salario && salario <= 800)
            {
                reajuste = (((salario * aumento2) / 100) + salario);
                percentual = 12;

                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste);
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
            }

            else if (800.01 <= salario && salario <= 1200)
            {
                reajuste = (((salario * aumento3) / 100) + salario);
                percentual = 10;

                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste);
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
            }

            else if (1200.01 <= salario && salario <= 2000)
            {
                reajuste = (((salario * aumento4) / 100) + salario);
                percentual = 7;

                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
            }

            else
            {
                reajuste = (((salario * aumento5) / 100) + salario);
                percentual = 4;

                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste);
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
            }
        }
    }
}
