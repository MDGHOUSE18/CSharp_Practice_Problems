using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Fundementals
{
    internal class Loops
    {
        public static void hello()
        {
            Console.Write("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());
            SumOfInt(num);
        }

        public static void SumOfInt(int num)
        {
            long sum = 0;
            for (long i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of integers from "+1+" to "+num+" is "+sum);
        }



    }
}
