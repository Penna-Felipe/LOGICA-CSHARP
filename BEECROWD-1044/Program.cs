using System;

namespace BEECROWD_1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int a, b, resto;

            entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}