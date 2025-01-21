using System;
using System.Globalization;

namespace BEECROWD_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, pi, volume;

            pi = 3.14159;
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0/3) * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}