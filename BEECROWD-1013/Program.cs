using System;
using System.Globalization;

namespace BEECROWD_1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums;
            int a, b, c, maior1, maior2;

            nums = Console.ReadLine().Split(' ');
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);

            maior1 = (a + b + Math.Abs(a - b)) / 2;
            maior2 = (maior1 + c + Math.Abs(maior1 - c)) / 2;

            Console.WriteLine(maior2 + " eh o maior");
        }
    }
}