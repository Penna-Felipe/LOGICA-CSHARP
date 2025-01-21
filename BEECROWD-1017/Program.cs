using System;
using System.Globalization;

namespace BEECROWD_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, velMedia;
            double dis, cons;

            horas = int.Parse(Console.ReadLine());
            velMedia = int.Parse(Console.ReadLine());

            dis = velMedia * horas;
            cons = dis / 12.0;

            Console.WriteLine(cons.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}