using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticeProblems.Data_Annotations
{
    /*
     * Login Form
        Description: Create a model for user login that includes username and password.
        Data Annotations to Practice:
        [Required] for both fields.
        [StringLength] to limit the length of the username and password.
        Custom validation for the password to enforce complexity (using a custom validation attribute).
     */
    class Login
    {
        [Required(ErrorMessage = "Username is required ")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Username Should contains between 6 to 10 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required ")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password should contain between 8 to 16 characters")]
        public string Password { get; set; }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"Username : {Username}, Password : {Password}";
        }

        public static void ValidateForm(Login form)
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
    internal class LoginForm
    {
        public static void Form()
        {
            Login login = new Login("ghouse18", "mdg123564");

            Console.WriteLine(login.ToString());

            Login.ValidateForm(login);
        }

        
    }
}
