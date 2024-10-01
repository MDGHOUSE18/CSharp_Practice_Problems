using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticeProblems.File_Handling
{
    internal class FileHandling
    {
        public static void fileHandling()
        {
            string path = @"C:\Users\Mahammed Ghouse\source\repos\PracticeProblems\PracticeProblems\File Handling\demo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File is exist!");
                //Console.WriteLine("Before ");
                //Console.WriteLine(File.ReadAllText(path));
                //File.WriteAllText(path,"This is a Demo File");
                File.AppendAllText(path, "This is a file named file.txt");
                //Console.WriteLine();
                //Console.WriteLine("After ");
                //Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File not exist!, we create one ");
            }


        }
    }
}
