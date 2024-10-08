using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticeProblems.Numerical_Questions;

namespace Unitz_Testing
{
    [TestClass]
    public class ManualTest
    {
        //public static void Main(string[] args)
        //{
        //    // Run test cases manually
        //    Test_Add_TwoNumbers_ReturnsSum();
        //    Test_Subtract_TwoNumbers_ReturnsDifference();
        //}
        [TestMethod]
        public static void Test_Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            if (result == expected)
            {
                Console.WriteLine("Test_Add_TwoNumbers_ReturnsSum: Passed");
            }
            else
            {
                Console.WriteLine("Test_Add_TwoNumbers_ReturnsSum: Failed");
            }
        }
        //[TestMethod]
        //public static void Test_Subtract_TwoNumbers_ReturnsDifference()
        //{
        //    // Arrange
        //    Calculator calculator = new Calculator();
        //    int a = 10;
        //    int b = 5;
        //    int expected = 5;

        //    // Act
        //    int result = calculator.Subtract(a, b);

        //    // Assert
        //    if (result == expected)
        //    {
        //        Console.WriteLine("Test_Subtract_TwoNumbers_ReturnsDifference: Passed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Test_Subtract_TwoNumbers_ReturnsDifference: Failed");
        //    }
        //}
    }

}
