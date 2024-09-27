using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Strings
{
    internal class UniqueCharacters
    {
        public static void uniqueChar()
        {
            string str = Console.ReadLine();
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (ch == str[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine(str + " have unique charaters");
            }
            else
            {
                Console.WriteLine(str + " not have unique characters");
            }
        }
    }
}
