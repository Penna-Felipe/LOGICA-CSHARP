using System;

namespace BEECROWD_1113
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

            while (x != y)
            {   
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
            entrada = Console.ReadLine().Split(' ');
            x = int.Parse(entrada[0]);
            y = int.Parse(entrada[1]);  
            }
        }
    }
}