using System;

namespace AumentoDeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario, reajuste, total;
            int percentual;
            const double aumento1 = 15, aumento2 = 12, aumento3 = 10, aumento4 = 7, aumento5 = 4;

            reajuste = 0;

            Double.TryParse(Console.ReadLine(), out salario );

            if (0 <= salario && salario <= 400)
            {
                reajuste = (((salario * aumento1) / 100) + salario);
                percentual = 15;

                total = reajuste - salario;
                Console.WriteLine("Novo salario: " + reajuste.ToString("F2") );
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2"));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }

            else if (400.01 <= salario && salario <= 800)
            {
                reajuste = (((salario * aumento2) / 100) + salario);
                percentual = 12;

                total = reajuste - salario;
                Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2"));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }

            else if (800.01 <= salario && salario <= 1200)
            {
                reajuste = (((salario * aumento3) / 100) + salario);
                percentual = 10;

                total = reajuste - salario;
                Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2"));
                Console.WriteLine("Em percentual: " + percentual +  " %");
            }

            else if (1200.01 <= salario && salario <= 2000)
            {
                reajuste = (((salario * aumento4) / 100) + salario);
                percentual = 7;

<<<<<<< HEAD
                Console.WriteLine("Novo salario:"); Console.WriteLine(reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho:"); Console.WriteLine(reajuste - salario);
                Console.WriteLine("Em percentual:"); Console.WriteLine(percentual + "%");
=======
                total = reajuste - salario;
                Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2"));
                Console.WriteLine("Em percentual: " + percentual + " %");
>>>>>>> 34a34728dff60a63698167d664ff4d0e820e0f83
            }

            else
            {
                reajuste = (((salario * aumento5) / 100) + salario);
                percentual = 4;

                total = reajuste - salario;
                Console.WriteLine("Novo salario: " + reajuste.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + total.ToString("F2"));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }

        }
    }
}
