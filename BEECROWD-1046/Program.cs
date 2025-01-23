using System;

namespace BEECROWD_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int a, b, duracao;

            entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);

            if(a < b){
                duracao = b - a;
            } else {
                duracao = 24 - a + b;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
