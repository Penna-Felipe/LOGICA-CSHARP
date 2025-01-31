using System;
using System.Globalization;

namespace EXERCICIO_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] entrada;
            string[] nome;
            double[] precoCompra;
            double[] precoVenda;

            n = int.Parse(Console.ReadLine());

            nome = new string[n];
            precoCompra = new double[n];
            precoVenda = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                nome[i] = entrada[0];
                precoCompra[i] = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            }
            
            double lucro;
            int lucroBaixo = 0;
            int lucroMediano = 0;
            int lucroAlto = 0;

            for (int i = 0; i < n; i++)
            {
                lucro =  ((precoVenda[i] * 100.00) / (precoCompra[i])) - 100.00;
                if(lucro < 10)
                {
                    lucroBaixo++;
                }
                else if(lucro > 20)
                {
                    lucroAlto++;
                }
                else
                {
                    lucroMediano++;
                }


            }

            double somaCompra = 0;
            double somaVenda = 0;
            double lucroTotal = 0;

            for(int i = 0; i < n; i++)
            {
                somaCompra += precoCompra[i];
                somaVenda += precoVenda[i];
                lucroTotal += precoVenda[i] - precoCompra[i];
            }

            Console.WriteLine("Lucro abaixo de 10%: " + lucroBaixo);
            Console.WriteLine("Lucro entre 10% e 20% : " + lucroMediano);
            Console.WriteLine("Lucro acima de 20%: " + lucroAlto);
            Console.WriteLine("Valor Total de compra: " + somaCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Total de venda: " + somaVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor Total de lucro: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}