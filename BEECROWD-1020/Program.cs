using System;

namespace BEECROWD_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ano - 365 dias, 1 mes - 30 dias, 
            int entrada, ano, mes, dias, resto;

            entrada = int.Parse(Console.ReadLine());
            
            ano = entrada / 365;
            resto = entrada % 365;
            Console.WriteLine(ano + " ano(s)");

            mes = resto / 30;
            resto = resto % 30;
            dias = resto;
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}