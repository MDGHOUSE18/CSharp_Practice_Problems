using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Arrays
{

    /*
     * 2) Write a C# Sharp program to read n values in an array and display them in reverse order.
        Test Data :
        Input the number of elements to store in the array :3
        Input 3 number of elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 7
        Expected Output:
        The values store into the array are:
        2 5 7
        The values store into the array in reverse are :
        7 5 2
     */
    internal class ReverseArray
    {
        public static void reverseArr()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine($"Input {len} number of elements in the array : ");
            for(int i = 0;i<len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are:");

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The values store into the array in reverse are :");
            for(int i=len-1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
