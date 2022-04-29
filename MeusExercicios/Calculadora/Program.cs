using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolver uma calculadora 
             * que vai ler um numero
             * depois vai ler um segundo numero
             * depois vai ler o operador
             * como resposta o programa vai
             * responder o resultado da
             * operação
             */

            // ler o primeiro numero
            // ler o segundo numero
            // ler o operador + - * /
            // verificar o tipo do operador
            // realizar a operação conforme o tipo verfificado
            // imprimir o resultado

            double numero1, numero2;
            double resultado;
            string operador;

            resultado = 0;

            Console.WriteLine("Digite seu primeiro valor");
            Double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite seu segundo valor");
            Double.TryParse(Console.ReadLine(), out numero2);

            Console.WriteLine("Digite o operador");
            operador = Console.ReadLine();

            if (operador == "+")

            {
                resultado = numero1 + numero2;
            }

            if (operador == "-")

            {
                resultado = numero1 - numero2;
            }

            if (operador == "*")
            {
                resultado = numero1 * numero2;
            }
            if (operador == "/")
            {
                if (numero2 == 0)

                {
                    Console.WriteLine("Não é possivel dividir por zero");
                }

                else

                {
                    resultado = numero1 / numero2;
                }

            }

            Console.WriteLine("Seu resultado final e");
            Console.WriteLine(resultado);

        }
    }
}
