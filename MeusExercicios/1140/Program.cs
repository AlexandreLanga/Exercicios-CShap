using System;

namespace _1140
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string frase = "";
            char primL;
=======
<<<<<<< HEAD
            int p1, p2, p3, p4;

            while (true)
            {
                String[] frase = Console.ReadLine().Split(' ');

                p1 = int.Parse(frase[0]);
                p2 = int.Parse(frase[1]);
                p3 = int.Parse(frase[2]);
                p4 = int.Parse(frase[3]);

                if (frase = "*")
                break;
            }


=======
            string frase;
>>>>>>> 0b8db849e6458a387a2f293bd9ebbe397608d24d

            while (true)
            {
                frase = Console.ReadLine();

                if (frase == "*")
                    break;

               var linha = frase.Split(' ');
                frase = frase.ToUpper();

                primL = frase[0];
                


<<<<<<< HEAD
               
            }
=======


            
            


           
>>>>>>> 34a34728dff60a63698167d664ff4d0e820e0f83
>>>>>>> 0b8db849e6458a387a2f293bd9ebbe397608d24d
        }
    }
}
