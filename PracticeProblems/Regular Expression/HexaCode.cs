using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticeProblems.Regular_Expression
{
    /*1. Write a C# Sharp program to check whether a given string is a valid Hex code or not. 
     *  Return true if this string is a valid code otherwise false.
        Sample Data:
        ("#CD5C5C") -> True
        ("#f08080") -> True
        ("#E9967A") -> True
        ("#EFFA07A") -> False
    */
    internal class HexaCode
    {
        public static void HexacodeOrNot()
        {
            string[] arr = { "#CD5C5C", "#f08080", "#E9967A", "#EFFA07A" };

            //string pattern = @"^#[0-9a-fA-f]{6}$";
            string pattern = @"^#[0-9a-fA-f]{6}\b";

            foreach (string s in arr)
            {
                bool result = Regex.IsMatch(s, pattern);
                Console.WriteLine($"{s} : {result}");
            }
        }
    }
}
