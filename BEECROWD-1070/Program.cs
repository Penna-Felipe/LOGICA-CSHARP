using System;

namespace BEECROWD_1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, numIm, count;

            entrada = int.Parse(Console.ReadLine());
            numIm = 0;
            count = 0;
            while (count < 6) 
            {   entrada ++;
                if(entrada % 2 != 0) 
                {
                    numIm = entrada;
                    Console.WriteLine(numIm);
                    count ++;
                }
            }
        }
    }
}