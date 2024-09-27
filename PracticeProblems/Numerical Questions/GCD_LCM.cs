using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    internal class GCD_LCM
    {
        public static int gcdOfNum(int num1,int num2)
        {
            int res = Math.Min(num1, num2);
            while (res > 0)
            {
                if(num1 % res == 0 && num2 % res == 0)
                {
                    break;
                }
                res--;
            }
            return res;
        }

        public static void gcd()
        {
            Console.Write("Enter the first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int gcd = gcdOfNum(num1,num2);
            int lcm = (num1*num2)/gcd;
            Console.WriteLine("GCD : " + gcd);
            Console.WriteLine("LCM : "+lcm);
        }
    }
}
