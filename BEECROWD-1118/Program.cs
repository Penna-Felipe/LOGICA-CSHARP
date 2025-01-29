using System;
using System.Globalization;

namespace BEECROWD_1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota, media, soma;
            int escolha, count;

            do 
            {  
                count = 0; 
                soma = 0.0;
                while (count < 2){
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota >= 0.0 && nota <= 10.0){
                        soma += nota;
                        count ++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }

                media = soma / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                escolha = int.Parse(Console.ReadLine());

                while (escolha != 1 && escolha != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    escolha = int.Parse(Console.ReadLine());
                }
                
            }while (escolha == 1);     
        }
    }
}