using System;
using System.Globalization;

namespace BEECROWD_1160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, pA, pB, pFA, pFB, anos;
            double g1, g2;
            string[] vet;

            t = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= t; i++)
            {   
                vet = Console.ReadLine().Split(' ');
                pA = int.Parse(vet[0]);
                pB = int.Parse(vet[1]);
                g1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                g2 = double.Parse(vet[3], CultureInfo.InvariantCulture);

                pFA = pA;
                pFB = pB;
                anos = 0;
                
                while (pFA <= pFB){
                    pFA += (int)(pFA * (g1/100)); 
                    pFB += (int)(pFB * (g2/100));
                    anos ++;
                }

                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
                else 
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
            }
        }
    }
}

