using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Strings
{
    internal class ReverseString
    {
        public static void reverseString()
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            string newStr = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newStr += arr[i] + " ";
            }
            Console.WriteLine("After reversing ");
            Console.WriteLine(newStr);
        }
    }
}
