using System;
using System.Globalization;

namespace BEECROWD_1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            int count, entrada, soma;

            entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0;
            count = 0;

            while (entrada > 0)
            {
                soma += entrada;
                count++;
                entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            media = (double) soma / count;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
