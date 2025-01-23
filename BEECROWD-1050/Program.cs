using System;

namespace BEECROWD_1050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ddd;
            string cidade;

            ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    cidade = "Brasilia";
                    Console.WriteLine(cidade);
                break;

                case 71:
                    cidade = "Salvador";
                    Console.WriteLine(cidade);
                break;

                case 11:
                    cidade = "Sao Paulo";
                    Console.WriteLine(cidade);
                break;
                
                case 21:
                    cidade = "Rio de Janeiro";
                    Console.WriteLine(cidade);
                break;

                case 32:
                    cidade = "Juiz de Fora";
                    Console.WriteLine(cidade);
                break;

                case 19:
                    cidade = "Campinas";
                    Console.WriteLine(cidade);
                break;

                case 27:
                    cidade = "Vitoria";
                    Console.WriteLine(cidade);
                break;

                case 31:
                    cidade = "Belo Horizonte";
                    Console.WriteLine(cidade);
                break;
                
                default:
                    Console.WriteLine("DDD nao cadastrado");
                break;
            }
        }
    }
}