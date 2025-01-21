using System;
using System.Globalization;

namespace BEECROWD_1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PROD, x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            PROD = x * y;
            Console.WriteLine("PROD = " + PROD);
        }
    }
}