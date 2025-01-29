using System;

namespace BEECROWD_1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, soma;

            entrada = int.Parse(Console.ReadLine());
            soma = 0;

            while (entrada != 0)
            {
                if (entrada % 2 == 0)
                {
                    for (int i = 0; i < 5; i++ )
                    {
                        soma += entrada;
                        entrada += 2;
                    }
                }
                else
                {
                    entrada += 1;
                    for (int i = 0; i < 5; i++ )
                    {
                        soma += entrada;
                        entrada += 2;
                    }
                }    
                Console.WriteLine(soma);
                soma = 0;
                entrada = int.Parse(Console.ReadLine());
            }
        }
    }
}