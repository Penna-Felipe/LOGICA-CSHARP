using System;

namespace BEECROWD_1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, numPar, numNeg, numPos, numIm;

            numPar = 0;
            numNeg = 0;
            numPos = 0;
            numIm = 0;
            for (int i = 1; i < 6; i++)
            {   
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    numPar += 1;

                    if (num > 0)
                    {
                        numPos += 1;
                    }
                    else if (num < 0)
                    {
                        numNeg += 1;
                    }
                }
                else 
                {
                    numIm += 1;

                    if (num > 0)
                    {
                        numPos += 1;
                    }
                    else if(num < 0)
                    {
                        numNeg += 1;
                    }
                }
            }
            Console.WriteLine(numPar + " valor(es) par(es)");
            Console.WriteLine(numIm + " valor(es) impar(es)");
            Console.WriteLine(numPos + " valor(es) positivo(s)");
            Console.WriteLine(numNeg + " valor(es) negativo(s)");
        }
    }
}