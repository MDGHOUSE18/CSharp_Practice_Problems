using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    internal class DecimalToBinary
    {
        public static void decimalToBinary()
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Binary representation: 0");
                return;
            }
            int[] arr = new int[32];
            int i = 0;
            while (num > 0)
            {
                arr[i++] = num % 2;
                num /= 2;
            }

            Console.Write("Binary representation: ");

            for (int j=i-1;j>=0;j--)
            {
                Console.Write(arr[j]);
            }
            Console.WriteLine();
        }
    }
}
