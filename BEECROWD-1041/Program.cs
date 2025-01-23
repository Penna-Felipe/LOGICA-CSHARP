using System;
using System.Globalization;

namespace MyApp
{
    internal class BEECROWD_1041
    {
        static void Main(string[] args)
        {
            string[] entrada; 
            double x, y;

            entrada = Console.ReadLine().Split(' ');
            x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if(y < 0 && x < 0) {
                Console.WriteLine("Q3");
            } 
            else if (y > 0 && x > 0) {
                Console.WriteLine("Q1");
            } 
            else if (y == 0 && x == 0) {
                Console.WriteLine("Origem");
            } 
            else if ( y > 0 && x < 0) {
                Console.WriteLine("Q2");
            } 
            else if (x == 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0) {
                Console.WriteLine("Eixo X");
            }
            else {
                Console.WriteLine("Q4");
            }
            
        }
    }
}