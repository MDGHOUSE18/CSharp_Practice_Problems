using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PracticeProblems.Collections.Generics
{
    internal class Generics
    {
        public static void generics()
        {
            int[] intArray = { 1, 2, 5, 7, 18, 9, 8, 15 };
            Console.WriteLine("Array of Integers ");
            printArray(intArray);
            Console.WriteLine("The maximum element in intArray is "+findMax(intArray));

            Console.WriteLine("Array of Doubles ");
            double[] doubleArray = { 11.2, 5.1, 6.4, 10.5, 6.25 };
            printArray(doubleArray);
            Console.WriteLine("The maximum element in doubleArray is " + findMax(doubleArray));

            Console.WriteLine("Array of Characters ");
            char[] charArray = { 'a', 'c', 'd', 'f', 'r', 'e', 'g', 's', 'm' };
            printArray(charArray);
            Console.WriteLine("The maximum element in charArray is " + findMax(charArray));

        }
        //Generic Method for printing Array
        public static void printArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }

        //public static void printIntArray(int[] arr)
        //{
        //    foreach (int item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public static void printDoubleArray(double[] arr)
        //{
        //    foreach (double item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

        //public static void printCharArray(char[] arr)
        //{
        //    foreach (char item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

        //Generic Method for Find Max
        public static T findMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;

        }

        //public static int findIntMax(int[] arr)
        //{
        //    int max = arr[0];
        //    foreach (int item in arr)
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;

        //}

        //public static double findDoubleMax(double[] arr)
        //{
        //    double max = arr[0];
        //    foreach (double item in arr)
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;

        //}

        //public static char findCharMax(char[] arr)
        //{
        //    char max = arr[0];
        //    foreach (char item in arr)
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;

        //}
    }
}
