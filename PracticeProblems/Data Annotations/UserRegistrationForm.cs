using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeProblems.Data_Annotations
{
    internal class UserRegistrationForm
    {
        /*
         *  User Registration Form
            Description: Create a model for user registration with fields like username, password, email, phone number, and date of birth.
            Data Annotations to Practice:
            [Required] for mandatory fields.
            [StringLength] for username and password length validation.
            [EmailAddress] for validating the email format.
            [Phone] for validating phone numbers.
            [DataType(DataType.Date)] for the date of birth field.
         */
        class RegistrationForm
        {
            [Required(ErrorMessage = "Username is Required")]
            [StringLength(16,MinimumLength =8, ErrorMessage = "Username must be between 8 and 16 characters")]
            public string Username { get; set; }

            [Required(ErrorMessage ="Password is Required")]
            [StringLength(16,MinimumLength =8, ErrorMessage = "Password must be between 8 and 16 characters")]
            public string Password { get; set; }

            [Required(ErrorMessage ="Email required")]
            [EmailAddress(ErrorMessage = "Invalid email format. Example: abc@gmail.com ")]
            public string Email { get; set; }

            [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage = "Date of birth is required")]
            [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
            public DateTime DOB { get; set; }


            public RegistrationForm(string username, string password, string email, string phoneNumber, DateTime dOB)
            {
                Username = username;
                Password = password;
                Email = email;
                PhoneNumber = phoneNumber;
                DOB = dOB;
            }

            public override string ToString()
            {
                return $"Username: {Username}, Password: {Password}, Email: {Email}, PhoneNumber: {PhoneNumber}, DOB: {DOB.ToShortDateString()}";
            }

            public static void ValidateForm(RegistrationForm form)
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


        public static void annotations()
        {
            // Create an instance of RegistrationForm
            RegistrationForm form = new RegistrationForm("ghouse123", "password23", "abc@gmail.com", "7989621872", new DateTime(2000, 9, 30));
            //RegistrationForm form = new RegistrationForm("user", "pass", "wrong-email-format", "12345", new DateTime(2000, 9, 18));


            // Print the form details
            Console.WriteLine(form);

            // Validate the form
            RegistrationForm.ValidateForm(form);
        }
    }
}
