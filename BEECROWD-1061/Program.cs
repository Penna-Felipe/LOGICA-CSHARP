using System;

namespace BEECROWD_1061
{
    internal class Program
    {
        static void Main(string[] args)
        {   int resto, resp, difTempo;

            string[] diaIncial = Console.ReadLine().Split(' ');
            int diaI = int.Parse(diaIncial[1]);
            string[] inicio = Console.ReadLine().Split(':');
            int horaI = int.Parse(inicio[0]);
            int minI = int.Parse(inicio[1]);
            int segI = int.Parse(inicio[2]);

            // TRANSFORMANDO EM SEGUNDOS

            diaI = diaI * 86400;
            horaI = horaI * 3600;
            minI = minI * 60;

            int totalI = diaI + horaI + minI + segI;

            string[] diaFinal = Console.ReadLine().Split(' ');
            int diaF = int.Parse(diaFinal[1]);
            string[] final = Console.ReadLine().Split(':');
            int horaF = int.Parse(final[0]);
            int minF = int.Parse(final[1]);
            int segF = int.Parse(final[2]);

            // TRANSFORMANDO TUDO EM SEGUNDOS

            diaF = diaF * 86400;
            horaF = horaF * 3600;
            minF = minF * 60;

            int totalF = diaF + horaF + minF + segF;

            difTempo = totalF - totalI;

            resp = difTempo / 86400;
            Console.WriteLine(resp + " dia(s)");
            resto = difTempo % 86400;

            resp = resto / 3600;
            Console.WriteLine(resp + " hora(s)");
            resto = resto % 3600;

            resp = resto / 60;
            Console.WriteLine(resp + " minuto(s)");
            resto = resto % 60;

            Console.WriteLine(resto + " segundo(s)");
        }
    }
}