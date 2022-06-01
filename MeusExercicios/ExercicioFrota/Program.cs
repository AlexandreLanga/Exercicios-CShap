using System;

namespace ExercicioFrota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motoristas motorista = new Motoristas();

            Console.WriteLine("Digite a sua CNH");
            motorista.CNH = Console.ReadLine();
            Console.WriteLine("Digite seu nome");
            motorista.nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            motorista.sobrenome = Console.ReadLine();

            motorista.ObterNomeCompleto();

            Veiculos veiculo = new Veiculos();

            Console.WriteLine("Digite sua placa");
            veiculo.placa = Console.ReadLine();
            Console.WriteLine("Digite sua marca");
            veiculo.marca = Console.ReadLine();
            Console.WriteLine("Digite o seu modelo");
            veiculo.modelo = Console.ReadLine();

            veiculo.ObterDescrição(veiculo.placa,veiculo.modelo);
            Console.WriteLine(veiculo.ObterDescrição(veiculo.placa, veiculo.modelo));
            Console.ReadKey();
        }
    }
}
