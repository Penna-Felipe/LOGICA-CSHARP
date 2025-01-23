using System;
using System.Globalization;

namespace BEECROWD_1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qntd;
            double total;
            string[] entrada;

            entrada = Console.ReadLine().Split(' ');
            cod = int.Parse(entrada[0]);
            qntd = int.Parse(entrada[1]);

            switch(cod){
                case 1:
                    total = qntd * 4.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = qntd * 4.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = qntd * 5.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = qntd * 2.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = qntd * 1.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
                    break;
            }
        }
    }
}