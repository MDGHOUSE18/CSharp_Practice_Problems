using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    internal class TwoSum
    {
        public static void pairs()
        {
            Console.Write("Enter the length of Array: ");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];

            Console.WriteLine("Enter the elements of the Array:");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the target : ");
            int target=int.Parse(Console.ReadLine());

            Console.Write("All pairs of integers in an array that add up to a given sum are ");
            for (int i = 0; i < len; i++)
            {
                for(int j=i+1; j < len; j++)
                {
                    if(arr[i] + arr[j] == target)
                    {
                        Console.Write("[" + i + " , " + j + "]");
                    }
                }
            }

        }
    }
}
