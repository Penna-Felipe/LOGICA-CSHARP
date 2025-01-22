using System;
using System.ComponentModel;
using System.Globalization;
namespace EXERCICIO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            double valor;

            entrada = int.Parse(Console.ReadLine());
            valor = 50.00;

            if (entrada <= 100) {
                Console.WriteLine("Valor a ser pago: R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                valor += ((entrada - 100) * 2.00);
                Console.WriteLine("Valor a ser pago: R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}