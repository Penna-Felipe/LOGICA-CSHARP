using System;
using System.Globalization;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main()
        {
           Console.WriteLine("Entre com seu nome completo:");
           string nome = Console.ReadLine();
           Console.WriteLine("Quantos quartos tem na sua casa");
           int num = int.Parse(Console.ReadLine());
           Console.WriteLine("Entre com o preco do produto");
           double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.WriteLine("Entre seu ultimo nome, idade e a altura");
           string[] frase = Console.ReadLine().Split(' ');
           string n = frase[0];
           int i = int.Parse(frase[1]);
           double a = double.Parse(frase[2]);

           Console.WriteLine(nome);
           Console.WriteLine(num);
           Console.WriteLine(preco);
           Console.WriteLine(n);
           Console.WriteLine(i);
           Console.WriteLine(a);

        }
    }
}
