using System;
using System.Globalization;

namespace BEECROWD_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //1 min - 60 seg
            //1 hora - 60 min / 3600 seg

            int entrada, seg, min, horas, restoHoras;

            entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horas = entrada / 3600;
            restoHoras = entrada % 3600;
            min = restoHoras / 60;
            seg = restoHoras % 60;

            Console.WriteLine(horas + ":" + min + ":" + seg);
        }
    }
}