using System;

namespace BEECROWD_1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, nota100, resto100, nota50, resto50, nota20, resto20, 
            nota10, resto10, nota5, resto5, nota2, resto2, nota1;

            entrada = int.Parse(Console.ReadLine());

            nota100 = entrada / 100;
            resto100 = entrada % 100;
            nota50 = resto100 / 50;
            resto50 = resto100 % 50;
            nota20 = resto50 / 20;
            resto20 = resto50 % 20;
            nota10 = resto20 / 10;
            resto10 = resto20 % 10;
            nota5 = resto10 / 5;
            resto5 = resto10 % 5;
            nota2 = resto5 / 2;
            resto2 = resto5 % 2;
            nota1 = resto2 / 1;

            Console.WriteLine(entrada);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");

        }
    }
}