using System;

namespace MyApp
{
    internal class BEECROWD_1047
    {
        static void Main(string[] args)
        {
            string [] entrada;
            int horaI, minI, horaF, minF, hora, min;

            entrada = Console.ReadLine().Split(' ');
            horaI = int.Parse(entrada[0]);
            minI = int.Parse(entrada[1]);
            horaF = int.Parse(entrada[2]);
            minF = int.Parse(entrada[3]);

            int inicio = horaI * 60 + minI;
            int final = horaF * 60 + minF;

            int duracao;

            if (inicio < final) {
                duracao = final - inicio;
            }
            else {
                duracao = (24 * 60 - inicio) + final;
            }

            hora = duracao / 60;
            min = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + min + " MINUTO(S)");
        }
    }
}