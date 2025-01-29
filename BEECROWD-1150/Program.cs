using System;

namespace BEECROWD_1150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, count, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (y <= x)
            {
                y = int.Parse(Console.ReadLine());
            }
            
            count = 0;
            soma = 0;
            
            do
            {
                soma += x;
                x += 1;
                count += 1;
            } while (soma <= y);

            Console.WriteLine(count);
           
        }
    }
}