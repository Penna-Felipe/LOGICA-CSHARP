using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ponto1;
            string[] ponto2;
            double x1, x2, y1, y2, dis, mX, mY;

            ponto1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);
            ponto2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

            mX = x2 - x1;
            mY = y2 - y1;    

            dis = Math.Sqrt(Math.Pow(mX, 2.0) + Math.Pow(mY, 2.0));
            
            Console.WriteLine(dis.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}