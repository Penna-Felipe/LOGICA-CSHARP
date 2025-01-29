using System;

namespace BEECROWD_1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            entrada = Console.ReadLine();

            while (entrada != "2002")
            {
                Console.WriteLine("Senha Invalida");
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}