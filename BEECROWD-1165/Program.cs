using System;

namespace BEECROWD_1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezes, n;
            
            vezes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= vezes; i++)
            {   
                n = int.Parse(Console.ReadLine());
                bool ehPrimo = true;
                if ( n == 1 || n == -1)
                {
                    ehPrimo = false;
                }
                else
                {
                    for(int j = 2; j * j <= n; j++)
                    {
                        if(n % j == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }
            if(ehPrimo){
            Console.WriteLine(n + " eh primo");
            }
            else
            {
                Console.WriteLine(n + " nao eh primo");
            }
            
            }

        }
    }
}
