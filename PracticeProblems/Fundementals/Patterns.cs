using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PracticeProblems.Fundementals
{
    internal class Patterns
    {
        public static void pattern()
        {
            Console.Write("Enter the no of rows : ");
            int num = int.Parse(Console.ReadLine());
            pattern11(num);
        }
        //Write a program in C# Sharp to display a right angle triangle with an asterisk.
        //The pattern like :

        //*
        //**
        //***
        //****
        public static void pattern1(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
        //The pattern like :

        //1
        //12
        //123
        //1234

        public static void pattern2(int num)
        {
            int c;
            for (int i = 0; i < num; i++)
            {
                c = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c+++" ");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
        //The pattern like :

        //1
        //22
        //333
        //4444
        public static void pattern3(int num)
        {
            int c = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c);
                }
                c++;
                Console.WriteLine();
            }
        }

        //Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
        //The pattern like :

        //1
        //2 3
        //4 5 6
        //7 8 9 10

        public static void pattern4(int num)
        {
            int c = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c+++" ");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.

        //   1 
        //  2 3 
        // 4 5 6 
        //7 8 9 10
        public static void pattern5(int num)
        {
            int c = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j=0;j<num-i;j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c+++" ");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

        //   *
        //  * *
        // * * *
        //* * * *
        public static void pattern6(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
        //The pattern like :

        //   1
        //  2 2
        // 3 3 3
        //4 4 4 4
        public static void pattern7(int num)
        {
            int c = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c+" ");
                }
                c++;
                Console.WriteLine();
            }
        }
        //Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.

        //  *
        // ***
        //*****
        public static void pattern8(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //Write a program in C# Sharp to print Floyd's Triangle. The Floyd's triangle is as below :

        //1 
        //01
        //101 
        //0101 
        //10101
        public static void pattern9(int num)
        {
            int p, q;
            for (int i = 0; i < num; i++)
            {
                if (i%2==0)
                {
                    p = 1;
                    q = 0;
                }
                else
                {
                    p = 0;
                    q = 1;
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(p);
                    }
                    else
                    {
                        Console.Write(q);
                    }
                }
                Console.WriteLine();
            }
        }

        //Write a program in C to display the pattern like a diamond.
        //The pattern is as follows :
        //      * 
        //     *** 
        //    ***** 
        //   *******
        //  *********
        //   *******
        //    *****
        //     ***
        //      *
        public static void pattern10(int num)
        {
            //upper part
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //lower part
            for (int i = num; i >= 0; i--)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //Write a program in C# Sharp to display such a pattern for n number of rows using a number starting with the number 1. The first and last number of each row will be 1.

        //  1
        // 121
        //12321
        public static void pattern11(int num)
        {
            int c;
            for (int i = 0; i < num; i++)
            {
                c = 1;
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c++);
                }
                c--;
                for (int j = i; j > 0; j--)
                {
                    Console.Write(--c);
                }
                Console.WriteLine();
            }
        }

    }
}
