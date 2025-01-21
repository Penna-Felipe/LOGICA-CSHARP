using System;
using System.Globalization;

namespace BEECROWD_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salBase, vendas, salTot;

             nome = Console.ReadLine();
             salBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
             salTot = salBase + (vendas * 0.15);

             Console.WriteLine("TOTAL = R$ " + salTot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
