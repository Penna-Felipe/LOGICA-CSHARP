using System;
using System.Globalization;

namespace BEECROWD_1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada;
            int resp, resto, moeda, nota;

            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int) (entrada * 100 + 0.5);

            Console.WriteLine("NOTAS:");
            
            nota = 100;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            nota = 50;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            nota = 20;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            nota = 10;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            nota = 5;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            nota = 2;
            resp = resto / (nota * 100);
            Console.WriteLine(resp + " nota(s) de R$ " + nota +  ".00"); 
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            resp = resto / moeda;
            Console.WriteLine(resp + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            resp = resto / moeda;
            Console.WriteLine(resp + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            resp = resto / moeda;
            Console.WriteLine(resp + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            resp = resto / moeda;
            Console.WriteLine(resp + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            resp = resto / moeda;
            Console.WriteLine(resp + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");            
        }
    }
}