using System;

namespace BEECROWD_1145
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

            for (int i = 1; i <= y; i ++)
            {   
                Console.Write(i);
                
                if (i % x == 0) 
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}