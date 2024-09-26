using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PracticeProblems
{
    internal class Characterfrequency
    {
        public static void charFrequency()
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();

            int[] freq = new int[26];
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch<='z')
                {
                    int index = ch-'a';
                    freq[index]++;
                }
            }

            

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    char ch = (char)(i + 'a');
                    Console.WriteLine(ch + " : " + freq[i]);
                }
            }
        }
    }
}
