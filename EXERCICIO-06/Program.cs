using System;
using System.Globalization;

namespace EXERCICIO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, soma;
            double media, cont;

            n = int.Parse(Console.ReadLine());

            soma = 0;
            cont = 0;

            if (n > 0) {   
                while (n > 0)
                {
                    soma += n;
                    cont +=1.0;
                    n = int.Parse(Console.ReadLine());
                }
                media = soma / cont;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else 
            {
                Console.WriteLine("impossivel calcular");
            }
        }
    }
}