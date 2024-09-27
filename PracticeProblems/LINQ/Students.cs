using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    internal class Students
    {
        /*
         * Problem Statement
         * Student Data Management
            1) Create Student class with Id, Name, Phone Number, Address and Age fields.
            - Create variable for List of Student class in Main method.
            - Add default values in created list
            - Display all student details.
            2) Retrieve all record from the list for age between 12 to 18 using linq.
            3) Sort students data in descending order based on TotalMarks.
            4) Display all the student records in each address.
            5) Fetch first three students records.
            6) Search particular student based on name.
         
         */
        class Student { 
            public int id {  get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string phoneNumber { get; set; }
            public string address { get; set; }
            public int totalMarks { get; set; }

            public Student(int id, string name, int age, string phoneNumber, string address, int totalMarks)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.phoneNumber = phoneNumber;
                this.address = address;
                this.totalMarks = totalMarks;
            }
        
        }
        public static void students()
        {
            Console.WriteLine("Student class");

            // Create a list of Students
            List<Student> studentList = new List<Student>
            {
                new Student(1, "John Doe", 15, "1234567890", "123 Main St", 550),
                new Student(2, "Jane Smith", 18, "0987654321", "456 Elm St", 600),
                new Student(3, "Alice Johnson", 20, "9876543210", "789 Pine St", 480),
                new Student(4, "Bob Brown", 17, "6549873210", "123 Main St", 490),
                new Student(5, "Charlie Green", 19, "3216549870", "654 Maple St", 450),
                new Student(6, "Diana Black", 16, "6543219870", "987 Birch St", 530),
                new Student(7, "Eva White", 14, "7418529630", "123 Cedar St", 570),
                new Student(8, "Frank Blue", 12, "9638527410", "456 Elm St", 400),
                new Student(9, "Grace Gray", 11, "8529637410", "789 Willow St", 300),
                new Student(10, "Hank Red", 13, "9637418520", "321 Redwood St", 350),
                new Student(11, "Ivy Purple", 15, "8527419630", "654 Magnolia St", 590),
                new Student(12, "Jack Orange", 18, "1239638520", "987 Cherry St", 560),
                new Student(13, "Kelly Yellow", 19, "6547893210", "321 Palm St", 480),
                new Student(14, "Leo Pink", 17, "9873216540", "456 Fir St", 520),
                new Student(15, "Mona Blue", 20, "1237419630", "789 Aspen St", 600)
            };

            // Display student details 
            //foreach (Student s in studentList)
            //{
            //    Console.WriteLine($"Id: {s.id}, Name: {s.name}, Age: {s.age}, Phone: {s.phoneNumber}, Address: {s.address}");
            //}

            //2) Retrieve all record from the list for age between 12 to 18 using linq.
            Console.WriteLine("Retrieve all record from the list for age between 12 to 18");
            var query1 = studentList.Where(s=>s.age>=12 && s.age<=18);
            DisplayStudentList(query1.ToList());
            Console.WriteLine();

            //3) Sort students data in descending order based on TotalMarks.
            Console.WriteLine("Sort students data in descending order based on TotalMarks");
            var query2 = studentList.OrderByDescending(s=>s.totalMarks);
            DisplayStudentList(query2.ToList());
            Console.WriteLine();

            //4) Display all the student records in each address.
            Console.WriteLine("Display all the student records in each address");
            var groupedStudents = studentList.GroupBy(s=>s.address);
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Address: {group.Key}");
                DisplayStudentList(group.ToList());
                Console.WriteLine(); // For spacing between addresses
            }

            //5) Fetch first three students records.
            Console.WriteLine("Fetch first three students records.");
            var query4 = studentList.Take(3);
            DisplayStudentList(query4.ToList());
            Console.WriteLine();

            //6) Search particular student based on name.
            Console.WriteLine("Search particular student based on name.");
            Console.Write("Enter the student name: ");
            string inputname = Console.ReadLine();
            var query5 = studentList.Where(s => s.name.Equals(inputname, StringComparison.OrdinalIgnoreCase));
            DisplayStudentList(query5.ToList());
            Console.WriteLine();

        }

        static void DisplayStudentList(List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                Console.WriteLine($"Id: {s.id}, Name: {s.name}, Age: {s.age}, Phone: {s.phoneNumber}, Address: {s.address}, TotalMarks: {s.totalMarks}");
            }
        }
    }
}
