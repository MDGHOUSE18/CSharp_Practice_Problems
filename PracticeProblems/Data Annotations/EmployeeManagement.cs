using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeProblems.Data_Annotations
{

    /*
         * Employee Management
            Description: Design a model for employee details with fields for name, email, phone number, job title, and hire date.
            Data Annotations to Practice:
            [Required] for name and job title.
            [EmailAddress] for email validation.
            [Phone] for phone number validation.
            [DataType(DataType.Date)] for hire date.
         * 
         */
    class Employee
    {

        [Required(ErrorMessage = "name is required ")]
        [StringLength(16, MinimumLength = 3)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email, Email format : abc@gmail.com")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Enter valid phone number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Job title is required")]
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public Employee(string name, string email, string phoneNumber, string jobTitle, DateTime hireDate)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            JobTitle = jobTitle;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"Name : {Name}, Email : {Email}, PhoneNumber : {PhoneNumber}, Job Title : {JobTitle}, Hire Date : {HireDate.ToShortDateString()}";
        }

        public static void ValidateForm(Employee form)
        {
            var context = new ValidationContext(form);
            var results = new System.Collections.Generic.List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(form, context, results, true);

            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Form is valid");
            }
        }

    }
    internal class EmployeeManagement
    {
        
        
        public static void eployeeManagement()
        {
            Employee employee = new Employee("Av","ava123gmail.com","1542365875","Devops",new DateTime(2024-9-2));

            Console.WriteLine(employee);


            Employee.ValidateForm(employee);



        }
    }
}
