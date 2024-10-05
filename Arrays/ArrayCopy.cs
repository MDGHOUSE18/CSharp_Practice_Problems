using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Arrays
{
    /*
     4. Write a C# Sharp program to copy the elements of one array into another array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 15
        element - 1 : 10
        element - 2 : 12
        Expected Output:
        The elements stored in the first array are :
        15 10 12
        The elements copied into the second array are :
        15 10 12
     */
    internal class ArrayCopy
    {
        public static void arrayCopy()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine($"Input {len} number of elements in the array : ");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] newarr = new int[arr.Length];

            for(int i=0; i<arr.Length;i++)
            {
                newarr[i] = arr[i];
            }

            Console.WriteLine("The elements stored in the first array are : ");
            foreach (int i in arr)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
            Console.WriteLine("The elements copied into the second array are :");
            foreach (int i in newarr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
