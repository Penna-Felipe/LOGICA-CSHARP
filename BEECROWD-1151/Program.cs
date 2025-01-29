using System;
using System.Reflection.Emit;

namespace BEECROWD_1151
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, ante, atual, prox;
            ante = 0;
            atual = 1;

            n = int.Parse(Console.ReadLine()); 

            if (n > 0 && n < 46)
            {
                for (int i = 1; i <= n; i ++)
                {
                    if (n == i)
                    {
                        Console.Write(ante);
                    }
                    else 
                    {
                        Console.Write(ante + " ");    
                        prox = ante + atual;
                        ante = atual;
                        atual = prox; 
                    }           
                }
            }
        }
    }
}
