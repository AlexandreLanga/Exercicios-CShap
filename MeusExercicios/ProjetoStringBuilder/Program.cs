using System;
using System.Text;

namespace ProjetoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Meu texto";
            texto += " extendido";
            texto += " ao infinito";
            texto += " e além";
            texto += " do ALUNO";

            StringBuilder mensagem = new StringBuilder();

            mensagem
                .AppendLine("Meu texto")
                .AppendLine(" extendido")
                .AppendLine(" ao infinito")
                .AppendLine(" e além do ALUNO");

            mensagem.Replace("ALUNO", "João");

            Console.WriteLine(mensagem.ToString());
            Console.WriteLine(texto.Replace("ALUNO","João"));

            StringBuilder mensagemDois = new StringBuilder();

            AdicionarTexto(mensagemDois);
            Console.WriteLine(mensagemDois.ToString());

            Console.ReadKey();
        }
        

        private static void AdicionarTexto(StringBuilder mensagem)
        {
            mensagem.Append("Texto adicionado no método");
        }
    }
}
