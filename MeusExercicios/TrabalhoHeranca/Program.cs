using System;

namespace TrabalhoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = CriarProfessor();
            Diretor diretor = CriarDiretor();
            ExibirProfessor(professor);
            ExibirDiretor(diretor);

            Console.ReadKey();
        }

        public static Professor CriarProfessor()
        {
            Console.WriteLine("Digite na linha 1 o número de seu professor:");
            Console.WriteLine("Digite na linha 2 o nome de seu professor:");
            Console.WriteLine("Digite na linha 3 o sobrenome de seu professor:");
            Console.WriteLine("Digite na linha 4 o salario de seu professor:");
            Console.WriteLine("Digite na linha 5 o curso em que é formado:");
            return new Professor()
            {
                Numero = Console.ReadLine(),
                Nome = Console.ReadLine(),
                Sobrenome = Console.ReadLine(),
                Salario = Double.Parse(Console.ReadLine()),
                Curso = Console.ReadLine(),
            };
        }

        public static Diretor CriarDiretor()
        {
            Console.WriteLine("Digite na linha 1 o número de seu diretor:");
            Console.WriteLine("Digite na linha 2 o nome de seu diretor:");
            Console.WriteLine("Digite na linha 3 o sobrenome de seu diretor:");
            Console.WriteLine("Digite na linha 4 o salario de seu diretor:");
            return new Diretor()
            {
                Numero = Console.ReadLine(),
                Nome = Console.ReadLine(),
                Sobrenome = Console.ReadLine(),
                Salario = Double.Parse(Console.ReadLine()),
            };
        }

        public static void ExibirProfessor(Professor professor)
        {
            Console.WriteLine("Seus dados são:");
            Console.WriteLine(professor.Nome);
            Console.WriteLine(professor.Sobrenome);
            Console.WriteLine(professor.Salario);
            Console.WriteLine(professor.Curso);
        }

        public static void ExibirDiretor(Diretor diretor)
        {
            Console.WriteLine("Seus dados são:");
            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.Sobrenome);
            Console.WriteLine(diretor.Salario);

        }

        
    }
}
