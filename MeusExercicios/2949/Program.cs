using System;

namespace _2949
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guerreiros;
            var anoes = 0;
            var elfos = 0;
            var humanos = 0;
            var magos = 0;
            var hobbits = 0;
            string raças;
            int.TryParse(Console.ReadLine(), out guerreiros);

            for (int i = 0; i < guerreiros; i++)
            {
                raças = Console.ReadLine();
                var vetorRaça = raças.Split(' ');

                if (vetorRaça[1] == "A")
                {
                    anoes = anoes + 1;
                }
                else if (vetorRaça[1] == "E")
                {
                    elfos = elfos + 1;
                }
                else if (vetorRaça[1] == "H")
                {
                    humanos = humanos + 1;
                }
                else if (vetorRaça[1] == "M")
                {
                    magos = magos + 1;
                }
                else if (vetorRaça[1] == "X")
                {
                    hobbits = hobbits + 1;
                }
            }
            Console.WriteLine($"{hobbits} Hobbit(s)");
            Console.WriteLine($"{humanos} Humano(s)");
            Console.WriteLine($"{elfos} Elfo(s)");
            Console.WriteLine($"{anoes} Anao(s)");
            Console.WriteLine($"{magos} Mago(s)");
        }
    }
}
