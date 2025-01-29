using System;

namespace BEECROWD_1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, par;

            par = 0;

            for(int i = 1; i < 6; i++)
            {   
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par +=1;
                }
                
            }
            Console.WriteLine(par + " valores pares");
        }
    }
}