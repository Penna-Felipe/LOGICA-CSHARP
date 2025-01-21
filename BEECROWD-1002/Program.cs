using System;
using System.Globalization;

namespace BEECROWD_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;
            n = 3.14159;
        
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n * Math.Pow(raio,2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}