using System;

namespace EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] entrada = Console.ReadLine().Split(' ');

            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);

            if (a >= b && a >= c){
                Console.WriteLine("MAIOR = " + a);
            } else 
                if (b >= c) {
                    Console.WriteLine("MAIOR = " + b);
                } else {
                        Console.WriteLine("MAIOR = " + c);
                    } 
            
            if (a <= b && a <= c){
                Console.WriteLine("MENOR = " + a);
            } else 
                if (b <= c) {
                    Console.WriteLine("MENOR = " + b);
                } else {
                        Console.WriteLine("MENOR = " + c);
                    } 
        }
    }
}