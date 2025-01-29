using System;
using System.Globalization;

namespace EXERCICIO_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            string[] nome;
            int [] idades; 
            double[] alturas;
            int n;
            int count;
            double soma;
            double media;
            double percent;

            n = int.Parse(Console.ReadLine());

            nome = new string[n];
            idades = new int[n]; 
            alturas = new double[n];

            soma = 0;
            media = 0;
            count = 0;

            for (int i = 0; i < n; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                nome[i] = entrada[0];
                idades[i] = int.Parse(entrada[1], CultureInfo.InvariantCulture);
                alturas[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            }

            //SOMAR AS ALTURAS E CONTAR MENOS DE 16
            for (int i = 0; i < n; i++)
            {
                soma += alturas[i];
                if(idades[i] < 16)
                {
                    count ++;
                }
            }
            
            media = soma / n;
            percent = (double) count / n * 100;

            Console.WriteLine("Altura Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Porcentagem de pessoas com menos de 16 anos: " + percent.ToString("F2", CultureInfo.InvariantCulture) + "%");

            
        }
    }
}