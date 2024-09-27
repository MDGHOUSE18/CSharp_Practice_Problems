using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeProblems
{
    internal class PrimeNumber
    {
        public static void primeNumber()
        {
            int num = int.Parse(Console.ReadLine());
            int count=0;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(num + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number");
            }
        }
        public static void primeNumberInRange()
        {
            Console.Write("Enter the starting number : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number : ");
            int end = int.Parse(Console.ReadLine());
            int count;
            Console.Write("The Prime numbers in range "+start+" to "+end+" are ");
            for (int num=start; num <= end; num++)
            {
                count = 0;
                if (num == 0 || num == 1) continue;
                for (int i = 2; i <num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write(num+" ");
                }
            }
        }
    }
}
