using System;

namespace Heranca
{
    internal class Heranca
    {
        static void Main(string[] args)
        {
            int tipo;
            Console.WriteLine("Informe o tipo de pessoa:");
            Console.WriteLine();
            Console.WriteLine("(1) Aluno");
            Console.WriteLine("(2) Professor");
            Console.WriteLine("(3) Diretor");
            Console.WriteLine();
            Console.WriteLine("Informe o tipo");

            int.TryParse(Console.ReadLine(), out tipo);

            Pessoa pessoa = CriarPessoa(tipo);

            ExibirNomeCompleto(pessoa);

            Console.ReadKey();
        }

        public static void ExibirNomeCompleto(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.ObterNomeCompleto());

            if(pessoa.GetType() == typeof(Professor))
                Console.WriteLine(((Professor)pessoa).NumeroFuncionario);
        }

        public static Pessoa CriarPessoa(int tipo)
        {
            if (tipo == 1)
                return CriarAluno();

            if (tipo == 2)
                return CriarProfessor();

            if (tipo == 3)
                return CriarDiretor();

            return null; 
        }

        public static Aluno CriarAluno()
        {
            return new Aluno()
            {
                CPF = "132.882.779.80",
                Nome = "Alexandre",
                Sobrenome = "Langa",
                MediaNotas = 9m,
                NumeroMatricula = "1001389686"
            };
        }

        public static Professor CriarProfessor()
        {
            return new Professor("1234")
            {
                CPF = "999.999.999-99",
                Nome = "Maria",
                Sobrenome = "Rocha",
                NumeroFuncionario = "1234",
                Salario = 1000.50m,
                Curso = "Programação",
            };
        }

        public static Diretor CriarDiretor()
        {
            return new Diretor("5678")
            {
                CPF = "123.654.789-25",
                Nome = "Matheus",
                Sobrenome = "Vieira",
                Salario = 5000.00m,
                Area = "Programção",
                NumeroFuncionario = "5678",
            };
        }
    }
}
