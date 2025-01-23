using System;
using System.Globalization;

namespace BEECROWD_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, porcentagem, reajuste, novoSalario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario <= 400.0){
                porcentagem = 15.0;
            } else if (salario <= 800.0){
                porcentagem = 12.0;
            } else if (salario <= 1200.0){
                porcentagem = 10.0;
            } else if (salario <= 2000.0){
                porcentagem = 7.0;
            } else {
                porcentagem = 4.0;
            }

            reajuste = (salario * porcentagem) / 100;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));	
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));	
            Console.WriteLine("Em percentual: " + porcentagem.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}