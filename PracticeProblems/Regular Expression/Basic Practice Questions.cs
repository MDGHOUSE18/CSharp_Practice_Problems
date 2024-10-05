using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticeProblems.Regular_Expression
{
    internal class Basic_Practice_Questions
    {
        //1. Match an Email Address
        //Question: Write a regex to match a basic email address format.
        //Sample Input: user @example.com
        //Expected Output: Match
        public static void EmailAddress()
        {
            Console.WriteLine("Enter the email : ");
            string email  = Console.ReadLine();

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern)) {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("Not Match");
            }
        }
    }
}
