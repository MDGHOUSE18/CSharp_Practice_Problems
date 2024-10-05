using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    /*
     4. Write a program in C# Sharp to display the number and frequency of a given number from an array.
        Expected Output :
        The number and the Frequency are :
        Number 5 appears 3 times
        Number 9 appears 2 times
        Number 1 appears 1 times
     */
    internal class ArrayFrequency
    {
        public static void Frequency()
        {
            int[] arr = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //var result = arr.Distinct().Select(x => new { num = x, count = arr.Count(n => n == x) }).OrderBy(n => n.num);
            var result = arr.GroupBy(n => n).OrderBy(n => n.Key);

            foreach (var x in result)
            {
                Console.WriteLine($"Number {x.Key} appears {x.Count()} times");
            }

        }
    }
}
