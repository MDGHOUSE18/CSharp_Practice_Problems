using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeProblems.Strings
{
    internal class Anagrams
    {
        public static void anagramOrNot()
        {
            Console.Write("Enter the first String : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string :");
            string str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not Anagram");
                return;
            }

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Not Anagram");
                    return;
                }
            }

            Console.WriteLine("Anagram");
        }
    }
}
