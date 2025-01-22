using System;
using System.Globalization;
namespace EXERCICIO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2) / 2.0;

            if (media > 60.0){
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
        }
    }
}