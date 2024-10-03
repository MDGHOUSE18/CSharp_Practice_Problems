using PracticeProblems.Data_Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    
   
    internal class Demo
    {

        public static void EmployeeMangement()
        {
            // Initialize the departments and employees using separate methods
            List<Departments> departments = InitializeDepartments();
            List<Employees> employees = InitializeEmployees();

            //var ITemp = employees.Where(e => e.Department == 1).OrderByDescending(e => e.Salary);

            //foreach (var employee in ITemp) {
            //    var department = departments.Find(d => d.DepartmentId==employee.Department);
            //    if (department != null) 
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} : {department.FullName} : {employee.Salary}");
            //    }
            //}

            var result = employees.Join(departments,
                emp => emp.Department,
                dept => dept.DepartmentId,
                (emp, dept) => new
                {
                    FullName = emp.FirstName + " "+emp.LastName,
                    Department = dept.FullName,
                    Salary = emp.Salary
                }).Where(e => e.Salary>60000);
            int count = 0;
            foreach (var emp in result) {
                Console.WriteLine($"FullName : {emp.FullName}, Department : {emp.Department}, Salary : {emp.Salary}");
                count++;
            }
            Console.WriteLine("Total Employees matched this condition is "+count);
        }

       
        public static void Display(List<Employees> employees, List<Departments> departments)
        {
            foreach (var emp in employees)
            {
                var department = departments.Find(d => d.DepartmentId == emp.Department);
                if (department != null)
                {
                    Console.WriteLine($"Employee: {emp.FirstName} {emp.LastName}, " +
                                      $"Department: {department.FullName}, " +
                                      $"Salary: {emp.Salary:C}, Experience: {emp.Experience} years");
                }
            }
        }

        // Method to initialize the list of departments
        static List<Departments> InitializeDepartments()
        {
            return new List<Departments>
        {
            new Departments { DepartmentId = 1, ShortName = "HR", FullName = "Human Resources" },
            new Departments { DepartmentId = 2, ShortName = "IT", FullName = "Information Technology" },
            new Departments { DepartmentId = 3, ShortName = "FIN", FullName = "Finance" },
            new Departments { DepartmentId = 4, ShortName = "MKT", FullName = "Marketing" },
            new Departments { DepartmentId = 5, ShortName = "OPS", FullName = "Operations" },
            new Departments { DepartmentId = 6, ShortName = "SALES", FullName = "Sales" }
        };
        }

        // Method to initialize the list of employees
        static List<Employees> InitializeEmployees()
        {
            return new List<Employees>
        {
            // Employees in HR
            new Employees { EmployeeId = 1, FirstName = "John", LastName = "Doe", Department = 1, Salary = 55000, Experience = 5 },
            new Employees { EmployeeId = 2, FirstName = "Anna", LastName = "Bell", Department = 1, Salary = 60000, Experience = 6 },
            new Employees { EmployeeId = 3, FirstName = "Mark", LastName = "Jones", Department = 1, Salary = 58000, Experience = 4 },
            new Employees { EmployeeId = 4, FirstName = "Lucy", LastName = "Adams", Department = 1, Salary = 62000, Experience = 7 },
            new Employees { EmployeeId = 5, FirstName = "Peter", LastName = "Wilson", Department = 1, Salary = 54000, Experience = 3 },

            // Employees in IT
            new Employees { EmployeeId = 6, FirstName = "Jane", LastName = "Smith", Department = 2, Salary = 70000, Experience = 8 },
            new Employees { EmployeeId = 7, FirstName = "David", LastName = "Baker", Department = 2, Salary = 75000, Experience = 9 },
            new Employees { EmployeeId = 8, FirstName = "Emily", LastName = "Johnson", Department = 2, Salary = 69000, Experience = 7 },
            new Employees { EmployeeId = 9, FirstName = "Michael", LastName = "Brown", Department = 2, Salary = 71000, Experience = 6 },
            new Employees { EmployeeId = 10, FirstName = "Sophia", LastName = "Green", Department = 2, Salary = 72000, Experience = 5 },
            new Employees { EmployeeId = 11, FirstName = "Daniel", LastName = "Clark", Department = 2, Salary = 76000, Experience = 10 },

            // Employees in Finance
            new Employees { EmployeeId = 12, FirstName = "Linda", LastName = "White", Department = 3, Salary = 64000, Experience = 6 },
            new Employees { EmployeeId = 13, FirstName = "James", LastName = "Hall", Department = 3, Salary = 63000, Experience = 5 },
            new Employees { EmployeeId = 14, FirstName = "Laura", LastName = "Taylor", Department = 3, Salary = 67000, Experience = 8 },
            new Employees { EmployeeId = 15, FirstName = "Thomas", LastName = "King", Department = 3, Salary = 62000, Experience = 4 },
            new Employees { EmployeeId = 16, FirstName = "Olivia", LastName = "Young", Department = 3, Salary = 66000, Experience = 7 },

            // Employees in Marketing
            new Employees { EmployeeId = 17, FirstName = "Chris", LastName = "Parker", Department = 4, Salary = 58000, Experience = 5 },
            new Employees { EmployeeId = 18, FirstName = "Megan", LastName = "Evans", Department = 4, Salary = 61000, Experience = 6 },
            new Employees { EmployeeId = 19, FirstName = "Paul", LastName = "Harris", Department = 4, Salary = 60000, Experience = 4 },
            new Employees { EmployeeId = 20, FirstName = "Alex", LastName = "Scott", Department = 4, Salary = 64000, Experience = 7 },
            new Employees { EmployeeId = 21, FirstName = "Isabella", LastName = "Wright", Department = 4, Salary = 62000, Experience = 5 },

            // Employees in Operations
            new Employees { EmployeeId = 22, FirstName = "Steven", LastName = "Lewis", Department = 5, Salary = 56000, Experience = 4 },
            new Employees { EmployeeId = 23, FirstName = "Rachel", LastName = "Walker", Department = 5, Salary = 58000, Experience = 6 },
            new Employees { EmployeeId = 24, FirstName = "Henry", LastName = "Roberts", Department = 5, Salary = 59000, Experience = 5 },
            new Employees { EmployeeId = 25, FirstName = "Grace", LastName = "Morris", Department = 5, Salary = 61000, Experience = 7 },
            new Employees { EmployeeId = 26, FirstName = "Ethan", LastName = "Thompson", Department = 5, Salary = 55000, Experience = 3 },

            // Employees in Sales
            new Employees { EmployeeId = 27, FirstName = "Andrew", LastName = "Perez", Department = 6, Salary = 60000, Experience = 6 },
            new Employees { EmployeeId = 28, FirstName = "Victoria", LastName = "Garcia", Department = 6, Salary = 63000, Experience = 7 },
            new Employees { EmployeeId = 29, FirstName = "Zach", LastName = "Martinez", Department = 6, Salary = 61000, Experience = 5 },
            new Employees { EmployeeId = 30, FirstName = "Emma", LastName = "Lee", Department = 6, Salary = 64000, Experience = 8 },
            new Employees { EmployeeId = 31, FirstName = "Joshua", LastName = "Davis", Department = 6, Salary = 59000, Experience = 4 }
        };
        }
    }
}
