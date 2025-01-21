using System;
using System.Globalization;

namespace BEECROWD_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double salario, salarioTot;
            
            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioTot = salario * horas;
                
            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + salarioTot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}