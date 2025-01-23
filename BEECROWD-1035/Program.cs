using System;

namespace BEECROWD_1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            String[] entrada;

            entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);
            d = int.Parse(entrada[3]);

            int somaAB = a + b;
            int somaCD = c + d;
            int verPar = a % 2;

            if (b > c && d > a && somaCD > somaAB && c > 0 && d > 0 && verPar == 0 ) {
                Console.WriteLine("Valores aceitos");
            } else {
                Console.WriteLine("Valores nao aceitos");
            }


        }
    }
}