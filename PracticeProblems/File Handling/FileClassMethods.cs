using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.File_Handling
{
    internal class FileClassMethods
    {
        public static void classMethods()
        {
            string filePath = @"C:\Users\Mahammed Ghouse\source\repos\PracticeProblems\PracticeProblems\File Handling\sample.txt";

            if (File.Exists(filePath))
            {
                // 1. Write text to a new file using WriteAllText
                File.WriteAllText(filePath, "Hello, India! This is the first line.\n");
                Console.WriteLine("File created and text written.");
            }

            // 2. Append text to the file using AppendAllText
            File.AppendAllText(filePath, "This is an additional line.\n");
            Console.WriteLine("Text appended to file.");

            // 3. Read all text from the file using ReadAllText
            string content = File.ReadAllText(filePath);
            Console.WriteLine("\nFile content:");
            Console.WriteLine(content);

            // 4. Check if the file exists using Exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nThe file exists.");

                // 5. Get file creation time using GetCreationTime
                DateTime creationTime = File.GetCreationTime(filePath);
                Console.WriteLine($"File created on: {creationTime}");
            }

            // 6. Delete the file using Delete
            //File.Delete(filePath);
            //Console.WriteLine("\nFile deleted.");
        }
    }
}
