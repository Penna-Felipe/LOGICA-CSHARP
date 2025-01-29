using System;

namespace EXERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string[] entrada;
            int[] vet;
            int n;

            n = int.Parse(Console.ReadLine());

            vet = new int[n];

            entrada = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(entrada[i]);
            }

            for(int i = 0; i < n; i++)
            {
                if(vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }  
            }

        }
    }
}