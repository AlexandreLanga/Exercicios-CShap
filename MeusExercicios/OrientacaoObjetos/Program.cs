using System;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funcao = 0;

            do
            {
                Console.WriteLine("Olá, seja bem vindo a central de manipulação do seu veiculo!");
                Console.WriteLine("");
                Console.WriteLine("Digite qual função deseja aplicar:");
                Console.WriteLine("(1) Verificar se o veiculo está ligado");
                Console.WriteLine("(2) Acelerar veiculo");
                Console.WriteLine("(3) Freiar veiculo");
                Console.WriteLine("(4) Desligar veiculo");
                Console.WriteLine("(5) Ligar veiculo");
                Console.WriteLine("(10) Sair do programa");
                int.TryParse(Console.ReadLine(), out funcao);  

                if (funcao == 1)
                {
                    
                }
                if (funcao == 2)
                {

                }
                if (funcao == 3)
                {

                }
                if (funcao == 4)
                {

                }
                if (funcao == 5)
                {

                }
                if (funcao == 10)
                {

                }
            } while (funcao != 10);
        }
    }
}
