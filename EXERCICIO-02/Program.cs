using System;
using System.Globalization;

namespace EXERCICIO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, metroQuad, area, preco;
            
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            metroQuad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * metroQuad;

            Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
} 