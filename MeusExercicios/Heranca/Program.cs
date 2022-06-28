using System;

namespace Heranca
{
    internal class Heranca
    {
        static void Main(string[] args)
        {
            Aluno aluno = CriarAluno();
            Professor professor = CriarProfessor();

            Console.WriteLine(aluno.ObterNomeCompleto());
            Console.WriteLine(professor.ObterNomeCompleto());
            Console.ReadKey();
        }

        public static void ExibirNomeCompleto(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.ObterNomeCompleto());

            if(pessoa.GetType() == typeof(Professor))
                Console.WriteLine(((Professor)pessoa).NumeroFuncionario);
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
            return new Professor()
            {
                CPF = "999.999.999-99",
                Nome = "Maria",
                Sobrenome = "Rocha",
                NumeroFuncionario = "1234",
                Salario = 1000.50m
            };
        }
    }
}
