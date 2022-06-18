using System;
using System.IO;

namespace DisplayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFiles();

        }

        public static void DisplayFiles()
        {
            string directoryPath = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data";
            string[] allFiles = Directory.GetFiles(directoryPath, "*.*");

            foreach (string file in allFiles)
            {
                string fileName = new FileInfo(file).Name;
                string fileCreateionDate = new FileInfo(file).CreationTime.ToString();
                Console.WriteLine($"{ fileName} { fileCreateionDate}");
            }
        }
    }
}
