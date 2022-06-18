using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter directory name:");
            string directoryName = Console.ReadLine();

            CreateDirectory(directoryName);
        }
        public static void CreateDirectory(string userDirectory)
        {
            string rootPath = @"C:\Users\Irina\source\repos\WorkingWithFiles\";

            string directoryPath = rootPath + userDirectory;

            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine($"Directory {userDirectory} already exists in {rootPath}.");
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory {userDirectory} has been created in {rootPath}.");
            }
        }
    }
}
