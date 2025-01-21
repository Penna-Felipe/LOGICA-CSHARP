using System;
using System.Globalization;

namespace BEECROWD_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frase1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(frase1[0]);
            int num1 = int.Parse(frase1[1]);
            double valor1 = double.Parse(frase1[2]);
            string[] frase2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(frase2[0]);
            int num2 = int.Parse(frase2[1]);
            double valor2 = double.Parse(frase2[2]);
            
            double total = (num1*valor1) + (num2*valor2);
            
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}