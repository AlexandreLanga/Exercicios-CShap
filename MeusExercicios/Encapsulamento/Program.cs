using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidades.Pessoa pessoa = CadastrarPessoa();
            Entidades.ContaBancaria contaBancaria = CadastrarContaBancaria(pessoa);
            Serviços.ContaBancaria servicoContaBancaria = new Serviços.ContaBancaria(contaBancaria);
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"Bem vindo {pessoa.ObterNomeCompleto()}");
                Console.WriteLine("");
                Console.WriteLine("Operações Disponiveis:");
                Console.WriteLine("(1) Consultar Saldo");
                Console.WriteLine("(2) Depositar");
                Console.WriteLine("(3) Sacar");
                Console.WriteLine("(9) Sair");
                Console.WriteLine("");
                Console.WriteLine("Informe a operação: ");

                int.TryParse(Console.ReadLine(), out operacao);

                if (operacao == 1)
                {
                    Console.WriteLine($"Seu saldo é: R$ {servicoContaBancaria.ObterSaldoAtual()}");
                }
                if (operacao == 2)
                {
                    Console.WriteLine($"Informe o valor: ");
                    decimal valorDepositar = 0.0m;
                    decimal.TryParse(Console.ReadLine(), out valorDepositar);
                    servicoContaBancaria.Depositar(valorDepositar);
                }
                if (operacao == 3)
                {
                    Console.WriteLine("Informe o valor: ");
                    decimal valorSacar = 0.0m;
                    decimal.TryParse(Console.ReadLine(), out valorSacar);
                    servicoContaBancaria.Sacar(valorSacar);
                }
                if (operacao == 9)
                {
                    Console.WriteLine($"Obrigado {pessoa.nome}");
                }
                else
                    Console.WriteLine("Operação Inválida");

                Console.ReadKey();
            } while (operacao != 9);
        }

        private static Entidades.ContaBancaria CadastrarContaBancaria(Entidades.Pessoa pessoa)
        {
            Entidades.ContaBancaria contabancaria = new Entidades.ContaBancaria();
            contabancaria.Pessoa = pessoa;
            contabancaria.Numero = 1234;
            contabancaria.Saldo = 0.0m;

            return contabancaria;
        }
        private static Entidades.Pessoa CadastrarPessoa()
        {
            Entidades.Pessoa pessoa = new Entidades.Pessoa();

            Console.WriteLine("Cadastro da Conta:");
            Console.WriteLine("Nome: ");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Sobrenome: ");
            pessoa.sobrenome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            pessoa.CPF = Console.ReadLine();

            return pessoa;
        }
    }
}
