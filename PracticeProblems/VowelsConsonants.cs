using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticeProblems
{
    internal class VowelsConsonants
    {
        public static void vowelsAndConsonatsCount()
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();

            int vowelCount = 0;
            int consCount = 0;

            foreach(char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowelCount++;
                }
                else
                {
                    consCount++;
                }
            }

            Console.WriteLine(str + " have "+vowelCount+" vowels and "+consCount+" consonants");
        }

        //Write a program that removes all vowels from a given string.
        public static void removeVowels()
        {
            Console.Write("Enter the String : ");
            string str = Console.ReadLine();

            string newStr = "";

            foreach(char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    continue;
                }
                newStr += c;
            }
            Console.WriteLine(newStr);
            Console.WriteLine();
        }
    }
}
