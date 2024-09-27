using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticeProblems
{
    internal class NumericalQuetions
    {
        //Write a program that calculates the compound interest for a given principal, rate, and time period.
        public static void calculateCI()
        {
            Console.WriteLine("Enter the principal amount: ");
            double P = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest per year: ");
            double I = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the time in years: ");
            double T = double.Parse(Console.ReadLine());

            // Calculate compound amount
            double Amount = P * Math.Pow((1 + I / 100), T);
            // Calculate compound interest
            double CompoundInterest = Amount - P;

            Console.WriteLine("Compound Interest is: " + CompoundInterest);
            Console.WriteLine("Total Amount (Principal + Interest) is: " + Amount);
        }

        //Write a program that generates a specified number of random numbers and prints them.

        public static void randomNumbers()
        {
            Console.Write("Enter the starting number : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number : ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("How many numbers you want to print : ");
            int num = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0 ; i < num; i++)
            {
                Console.WriteLine(random.Next(start,end));
            }
        }
    }
}
