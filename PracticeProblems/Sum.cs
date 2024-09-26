using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    internal class Sum
    {
        public static void sumOfInt()
        {
            Console.Write("Enter the Numeber : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num>0)
            {
                sum = sum+(num%10);
                num = num / 10;
            }
            Console.WriteLine("Sum of Digits are " + sum);
        }
    }
}
