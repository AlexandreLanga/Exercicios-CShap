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

            double salario, reajuste, percentual;


            Double.TryParse(Console.ReadLine(), out salario);

            if (0 <= salario && salario <= 400)
            { 

            }

        }
    }
}
