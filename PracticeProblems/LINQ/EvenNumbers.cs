using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    internal class EvenNumbers
    {

        /*
         * 1. Write a program in C# Sharp to show how the three parts of a query operation execute.
            Expected Output:
            The numbers which produce the remainder 0 after divided by 2 are :
            0 2 4 6 8
         */
        public static void Numbers()
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Select(n => n % 2 == 0);
            var result = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are :");
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
        }
    }
}
