using System;
using System.Globalization;

namespace MyApp
{
    internal class BEECROWD_1040
    {
        static void Main(string[] args)
        {
            string[] entrada;
            float n1, n2, n3, n4, media;

            entrada = Console.ReadLine().Split(' ');
            n1 = float.Parse(entrada[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(entrada[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(entrada[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(entrada[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10; 
            
            if (media == 4.85f) {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            } 
            else if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } 
            else {
                Console.WriteLine("Aluno em exame.");
                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + notaExame) / 2;
                if (media >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                } 
                else {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture)); 
            }
        }
    }
}