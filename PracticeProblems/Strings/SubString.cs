using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Strings
{
    internal class SubString
    {
        public static void subString()
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            string unique = "";

            foreach (char c in str)
            {
                if (!unique.Contains(c))
                {
                    unique += c;
                }
            }

            Console.Write("The longest substring in a given string that does not contain any repeating characters are " + unique);
        }
    }
}
