using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Arrays
{
    /*
        3) Write a program in C# Sharp to find the sum of all array elements.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 8
        Expected Output :
        Sum of all elements stored in the array is : 15
     */
    internal class SumOfElements
    {
        public static void sum()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine($"Input {len} number of elements in the array : ");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            long sum = 0;

            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all elements stored in the array is : "+sum);
        }
    }
}
