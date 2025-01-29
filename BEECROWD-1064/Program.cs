using System;
using System.Globalization;

namespace BEECROWD_1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, soma, media;
            int numP;

            soma = 0;
            numP = 0;

            for (int i = 1; i < 7; i++ )
            {
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num >= 0) {
                    numP += 1;
                    soma += num;
                }                
            }	
            media = soma / numP;
            Console.WriteLine(numP + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}