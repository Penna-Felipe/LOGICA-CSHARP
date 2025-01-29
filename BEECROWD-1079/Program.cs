using System;
using System.Globalization;

namespace BEECROWD_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums;
            int vezes;
            double n1, n2, n3, media;
            
            vezes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= vezes; i++)
            {
                nums = Console.ReadLine().Split();
                n1 = double.Parse(nums[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(nums[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(nums[2], CultureInfo.InvariantCulture);
                media = ((n1*2) +  (n2*3) + (n3*5)) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}