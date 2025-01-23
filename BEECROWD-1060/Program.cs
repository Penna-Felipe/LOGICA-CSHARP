using System;
using System.Globalization;

namespace BEECROWD_1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
             
            int numP = 0;

            for (int i = 1; i < 7; i++)
            {
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num >= 0.0)
                {
                    numP += 1;
                }
            }
            Console.WriteLine(numP + " valores positivos");
        }
    }
}