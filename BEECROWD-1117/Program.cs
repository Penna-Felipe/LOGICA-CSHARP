using System;
using System.Globalization;

namespace BEECROWD_1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, media, soma;
            int count;
            
            count = 0;
            soma = 0.0;

            do
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0.0 && nota <= 10.0 )
                {
                    soma += nota;
                    count++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            } while (count < 2);
            media = soma / count;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}