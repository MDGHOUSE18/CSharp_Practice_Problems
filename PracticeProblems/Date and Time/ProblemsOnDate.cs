using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    internal class ProblemsOnDate
    {

        // 1. Find the Day of the Week for a Given Date
        public static void DayOfWeekForGivenDate()
        {
            Console.WriteLine("Enter day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            Console.WriteLine($"The day of the week is: {date.DayOfWeek}");
        }

        // 2. Add Days to a Given Date
        public static void AddDaysToDate()
        {
            Console.WriteLine("Enter day:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of days to add:");
            int daysToAdd = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            DateTime newDate = date.AddDays(daysToAdd);
            Console.WriteLine($"The new date is: {newDate.ToString("dd-MM-yyyy")}");
        }

        // 3. Calculate Difference Between Two Dates
        public static void DifferenceBetweenTwoDates()
        {
            Console.WriteLine("Enter first date (dd/mm/yyyy):");
            string[] firstDate = Console.ReadLine().Split('/');
            int day1 = int.Parse(firstDate[0]);
            int month1 = int.Parse(firstDate[1]);
            int year1 = int.Parse(firstDate[2]);

            Console.WriteLine("Enter second date (dd/mm/yyyy):");
            string[] secondDate = Console.ReadLine().Split('/');
            int day2 = int.Parse(secondDate[0]);
            int month2 = int.Parse(secondDate[1]);
            int year2 = int.Parse(secondDate[2]);

            DateTime date1 = new DateTime(year1, month1, day1);
            DateTime date2 = new DateTime(year2, month2, day2);

            TimeSpan difference = date2 - date1;
            Console.WriteLine($"The difference in days is: {difference.Days}");
        }

        // 4. Calculate Age Based on Birth Date
        public static void CalculateAge()
        {
            Console.WriteLine("Enter your birth date (dd/mm/yyyy):");
            string[] birthDate = Console.ReadLine().Split('/');
            int birthDay = int.Parse(birthDate[0]);
            int birthMonth = int.Parse(birthDate[1]);
            int birthYear = int.Parse(birthDate[2]);

            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = DateTime.Now;

            int age = today.Year - birth.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (today.Month < birth.Month || (today.Month == birth.Month && today.Day < birth.Day))
            {
                age--;
            }

            Console.WriteLine($"Your age is: {age} years");
        }

        // 5. Calculate Days Until Next Birthday
        public static void DaysUntilNextBirthday()
        {
            Console.WriteLine("Enter your birth date (dd/mm/yyyy):");
            string[] birthDate = Console.ReadLine().Split('/');
            int birthDay = int.Parse(birthDate[0]);
            int birthMonth = int.Parse(birthDate[1]);
            int birthYear = int.Parse(birthDate[2]);

            DateTime today = DateTime.Now;
            DateTime nextBirthday = new DateTime(today.Year, birthMonth, birthDay);

            // If the birthday has already passed this year, calculate for next year
            if (nextBirthday < today)
            {
                nextBirthday = new DateTime(today.Year + 1, birthMonth, birthDay);
            }

            TimeSpan daysUntilBirthday = nextBirthday - today;
            Console.WriteLine($"Days until your next birthday: {daysUntilBirthday.Days}");
        }
    }
}
