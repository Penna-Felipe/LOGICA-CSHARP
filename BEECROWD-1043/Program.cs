using System;
using System.Globalization;

namespace BEECROWD_1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            double a, b, c, area, per;

            entrada = Console.ReadLine().Split(' ');
            a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (a > b + c && b > a + c && c > b + a)
            {
                per = a + b + c;
                Console.WriteLine("Perimetro " + per.ToString("F1", CultureInfo.InvariantCulture));
            } 
            else 
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

            //  if ( a > b  && a > c) 
            // {
            //     pri = a;
            //     if ( b > c )
            //     {
            //         seg = b;
            //         ter = c;
            //     }
            //     else 
            //     {
            //         seg = c;
            //         ter = b;
            //     }
            // } 
            // else if ( b > c ) 
            // {
            //     pri = b;
            //     if( a > c ) 
            //     {
            //         seg = a;
            //         ter = c;
            //     }
            //     else 
            //     {
            //         seg = c;
            //         ter = a;
            //     }
            // }
            // else 
            // {
            //     pri = c;
            //     if( a > b ) 
            //     {
            //         seg = a;
            //         ter = b;
            //     }
            //     else 
            //     {
            //         seg = b;
            //         ter = a;
            //     }
            // }
            // if ( pri < seg + ter)
            // {
            //     per = pri + seg + ter;
            //     Console.WriteLine("Perimetro = " + per.ToString("F1", CultureInfo.InvariantCulture));
            // }
            // else 
            // {
            //     area = ((a+b)*c) / 2;
            //     Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            // }
        }
    }
}
