using System;
using System.Globalization;

namespace MyApp
{
    internal class BEECROWD_1045
    {
        static void Main(string[] args)
        {
            string[] entrada;
            double a, b, c, n1, n2, n3;

            entrada = Console.ReadLine().Split(' ');
            n1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3){
                a = n1;
                if (n2 > n3) {
                    b = n2;
                    c = n3;
                } 
                else {
                    b = n3;
                    c = n2;
                }
            } 
            else if (n2 > n3) {
                a = n2;
                if (n1 > n3) {
                    b = n1;
                    c = n3;
                } 
                else {
                    b = n3;
                    c = n1;
                }
            } 
            else {
                a = n3;
                if(n1 > n2) {
                    b = n1;
                    c = n2;
                } 
                else {
                    b = n2;
                    c = n1;
                } 
            }

            bool ehTrinagulo = a < b + c;   
            bool ehAcutangulo = Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2);
            bool ehObtusangulo = Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2);
            bool ehEquilatero = a == b && b == c;
            bool ehIsosceles = a == b || b == c || a == c;
        
                if (ehTrinagulo) {
                    if (ehAcutangulo) {
                        Console.WriteLine("TRIANGULO ACUTANGULO");
                    } 
                    else if (ehObtusangulo) {
                        Console.WriteLine("TRIANGULO OBTUSANGULO");
                    } 
                    else {
                        Console.WriteLine("TRIANGULO RETANGULO");
                    }
                    
                    if(ehEquilatero) {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    } 
                    else if (ehIsosceles) {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                } else {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
        }
    }
}