using System;
using System.Globalization;

namespace BEECROWD_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, CONS;

            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X = int.Parse(Console.ReadLine());

            CONS = X / Y;
            
            Console.WriteLine(CONS.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}