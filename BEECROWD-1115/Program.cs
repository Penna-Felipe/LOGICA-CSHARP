using System;

namespace BEECROWD_1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int x, y;

            entrada = Console.ReadLine().Split(' ');
            x = int.Parse(entrada[0]);
            y = int.Parse(entrada[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {  
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }

        }
    }
}