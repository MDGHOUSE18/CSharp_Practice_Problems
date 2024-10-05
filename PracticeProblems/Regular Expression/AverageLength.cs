using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeProblems.Regular_Expression
{
    /*
     2. Write a C# Sharp program to calculate the average word length in a given string. 
        Round the average length up to two decimal places.
        Sample Data:
        ("CPP Exercises." -> 6
        ("C# syntax is highly expressive, yet it is also simple and easy to learn.") -> 4
        (“C# is an elegant and type-safe object-oriented language") -> 5.62
     */
    internal class AverageLength
    {

        public static void AvgWordLength()
        {
            Console.WriteLine("Enter the sentance : ");
            string input = Console.ReadLine();

            //string pattern = @"\w+";
            string pattern = @"[^A-Za-z ]";

            MatchCollection matches = Regex.Matches(input, pattern);

            string new_text = Regex.Replace(input, "[^A-Za-z ]", "");
            double avg = new_text.Split(' ').Select(word => word.Length).Average();
            Console.WriteLine(new_text);

            //int wordlength = 0, wordcount = matches.Count;
            //foreach (Match match in matches)
            //{
            //    int len = match.Value.Length;
            //    wordlength += len;
            //}
            ////double avg = (wordcount>0)?wordlength/wordcount:0;
            //Console.WriteLine($"WordCount : {wordcount} WordLength : {wordlength}");
            Console.WriteLine($"Average Length of words in given sentance is {Math.Round(avg,2)}");

        }

    }
}
