using System;
using System.Globalization;

namespace BEECROWD_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dis, tempo;

            dis = int.Parse(Console.ReadLine());
            tempo = dis * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}