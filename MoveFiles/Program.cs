using System;
using System.IO;
namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\Irina\source\repos\WorkingWithFiles\myData\";

            Console.WriteLine($"Enter the file name to be moved from Data to myData:");
            string fileName = Console.ReadLine();

            string filePath = sourceDirectory + fileName + ".txt";

            if(File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + fileName + ".txt");
                Console.WriteLine($"Fike {fileName} has been moved to a new directory.");
            }
            else
            {
                Console.WriteLine($"{fileName} not found in Data.");
            }

        }
    }
}
