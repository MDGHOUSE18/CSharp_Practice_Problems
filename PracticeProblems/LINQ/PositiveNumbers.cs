using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    /*
     * 2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
        Expected Output:
        The numbers within the range of 1 to 11 are :
        1 2 3 4 6 9 10 
     */
    internal class PositiveNumbers
    {
        public static void Numbers()
        {
            int[] numbers = new int[15]{ 1, 3, -2, -4, -7, -3, -8, 2, 12, 19,4, 6, 9, 10, 14 };

            var positives = numbers.Where(n => (n > 0) &&(n<11)).OrderBy(n => n);

            Console.WriteLine("The numbers within the range of 1 to 11 are :");
            foreach (var item in positives)
            {
                Console.Write(item+" ");
            }

        }
    }
}
