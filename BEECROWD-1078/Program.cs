using System;

namespace BEECROWD_1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int resp = n * i;
                Console.WriteLine(i + " x " + n + " = " + resp);
            }
        }
    }
}