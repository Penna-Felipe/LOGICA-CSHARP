using System;

namespace BEECROWD_1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int a, b, c, pri, seg, ter;

            entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);

            if ( a > b  && a > c) 
            {
                pri = a;
                if ( b > c )
                {
                    seg = b;
                    ter = c;
                }
                else 
                {
                    seg = c;
                    ter = b;
                }
            } 
            else if ( b > c ) 
            {
                pri = b;
                if( a > c ) 
                {
                    seg = a;
                    ter = c;
                }
                else 
                {
                    seg = c;
                    ter = a;
                }
            }
            else 
            {
                pri = c;
                if( a > b ) 
                {
                    seg = a;
                    ter = b;
                }
                else 
                {
                    seg = b;
                    ter = a;
                }
            }
            Console.WriteLine(ter);
            Console.WriteLine(seg);
            Console.WriteLine(pri);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

