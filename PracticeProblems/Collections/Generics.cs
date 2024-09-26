using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Collections
{
    internal class Generics
    {
        public static void generics()
        {
            int[] intArray = { 1, 2, 5, 7, 18, 9, 8, 15 };
            Console.WriteLine("Array of Integers ");
            printArray(intArray);
            Console.WriteLine();

            Console.WriteLine("Array of Doubles ");
            Double[] doubleArray = { 11.2, 5.1, 6.4, 10.5,6.25 };
            printArray(doubleArray);
            Console.WriteLine() ;

            Console.WriteLine("Array of Characters ");
            char[] charArray = {'a','c','d','f','r','e','g','s','m' };
            printArray(charArray);
            Console.WriteLine();

        }

        public static void printArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }

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


    }
}
