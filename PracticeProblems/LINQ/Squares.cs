using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    /*
     * 3. Write a program in C# Sharp to find the number of an array and 
     * the square of each number which is more than 20.
        Expected Output :
        { Number = 9, SqrNo = 81 }
        { Number = 8, SqrNo = 64 }
        { Number = 6, SqrNo = 36 }
        { Number = 5, SqrNo = 25 }
     */
    internal class Squares
    {
        public static void Numbers()
        {
            int[] numbers = { 3, 9, 2, 8, 6, 5 };

            var squares = numbers.Select(n => new { n, sq=n*n}).
                Where(item => item.sq>20).ToList();

            foreach (var num in squares)
            {
                Console.WriteLine($"Numbers = {num.n}, Square = {num.sq}");
            }
        }
    }
}
