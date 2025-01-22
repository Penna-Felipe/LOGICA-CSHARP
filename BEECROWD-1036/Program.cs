using System;
using System.Globalization;
namespace BEECROWD_1036
{
    internal class BEECROWD_1036
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;
            
            string[] entrada = Console.ReadLine().Split(' ');

            a = double.Parse(entrada[0]);
            b = double.Parse(entrada[1]);
            c = double.Parse(entrada[2]);

            delta = (Math.Pow(b, 2)) - (4 * a * c);
            r1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            r2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0 || a <= 0 ){
                Console.WriteLine("Impossivel calcular");
            } else {
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }


        }
    }
}