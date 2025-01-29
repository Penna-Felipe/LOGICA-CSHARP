using System;
using System.Globalization;

namespace EXERCICIO_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            string[] entrada;
            int n;

            n = int.Parse(Console.ReadLine());

            vet = new double[n];

            entrada = Console.ReadLine().Split(' ');

            double soma = 0;
            double media;

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                soma += vet[i];
            }
            Console.WriteLine();
            media = soma / n;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));


            
        }
    }
}