using System;
using System.IO;
using Newtonsoft.Json;


namespace PracticeProblems.File_Handling
{
    internal class JsonFileExample
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            
        }
        public static void jsonExample()
        {
            string path = @"C:\Users\Mahammed Ghouse\source\repos\PracticeProblems\PracticeProblems\File Handling\data.json";

            // Create a sample object
            var person = new Person
            {
                Name = "Mahammed Ghouse",
                Age = 30,
                Email = "mdghouse45@gmail.com"
            };

            // 1. Serialize object to JSON and write to a file
            string jsonString = JsonConvert.SerializeObject(person,Formatting.Indented);
            File.WriteAllText(path, jsonString);
            Console.WriteLine("JSON data written to file.");

            // 2. Read JSON data from file
            string jsonFromFile = File.ReadAllText(path);
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonFromFile);
            Console.WriteLine("\nRead from JSON file:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Email: {deserializedPerson.Email}");

            // 3. Delete the JSON file
            //File.Delete(path);
            //Console.WriteLine("\nJSON file deleted.");
        }
    
    }
}
