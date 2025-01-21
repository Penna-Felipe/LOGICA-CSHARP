using System;
using System.Globalization;

namespace BEECROWD_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums;
            double  a, b, c, aTri, aCir, aTra, aQuad, aRet;
            double pi = 3.14159;
            
            nums = Console.ReadLine().Split(' ');


            a = double.Parse(nums[0]);
            b = double.Parse(nums[1]);
            c = double.Parse(nums[2]);

            aTri = (a * c) / 2;
            aCir = pi * Math.Pow(c, 2);
            aTra = ((a + b) * c) / 2;
            aQuad = b * b;
            aRet = a * b;

            Console.WriteLine("TRIANGULO: " + aTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + aCir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + aTra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + aQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + aRet.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}