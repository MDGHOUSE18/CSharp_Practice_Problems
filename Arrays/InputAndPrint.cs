using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Arrays
{
    /*
     * 1. Write a C# Sharp program that stores elements in an array and prints them.
        Test Data:
        Input 10 elements in the array:
        element - 0 : 1
        element - 1 : 1
        element - 2 : 2
        .......
        Expected Output :
        Elements in array are: 1 1 2 3 4 5 6 7 8 9
     */
    public class InputAndPrint
    {
        public static void input()
        {
            int[] arr = new int[10];
            Console.WriteLine("Input 10 elements in the array ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are :");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
