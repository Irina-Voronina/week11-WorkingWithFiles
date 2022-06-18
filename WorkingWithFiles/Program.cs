using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение позволяет пользователю выбрать операцию с файлом
            //create - программа создаст для пользователя файл с веденным пользователем именем в папке Data
            //move - программа переместит выбранный пользователем файл в папку myData
            //delete - программа удалит выбранный пользователем файл из папки Data
            //приложение должно работать с помощью функций, вызываемых в методе Main
            //week12-WorkingWithFiles


            Console.WriteLine("Operations with files. In the Data directory.");

            OperationSelection();
            CreateFile();
            DisplayFilesData();
            MoveFile();
            DisplayFilesMyData();
            DeleteFile();
            Continuation();
            Sentiment();
        }

        public static void OperationSelection()
        {
            Console.WriteLine();
            Console.WriteLine("Enter [1] if you want to create a file, " +
                "enter [2] if you want to move a file, " +
                "enter [3] if you want to delete a file: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine();
                DisplayFilesData();
                Console.WriteLine();
                Console.WriteLine("Enter a name for the new file:");
                CreateFile();
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                DisplayFilesData();
                Console.WriteLine();
                MoveFile();
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                DisplayFilesData();
                Console.WriteLine();
                Console.WriteLine("Enter the name of the file to delete:");
                DeleteFile();
            }
            else
            {
                Console.WriteLine("Incorrect choice.");
                OperationSelection();
            }
        }

        public static void CreateFile()
        {
            Console.WriteLine();
            string fileName = Console.ReadLine();

            string fileRoot = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data\";

            string filePath = fileRoot + fileName + ".txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File {fileName}.txt already exists in {fileRoot}.");
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine($"File {fileName}.txt has been created in {fileRoot}.");
            }

            DisplayFilesData();
            Continuation();
        }

        public static void DisplayFilesData()
        {
            Console.WriteLine();
            Console.WriteLine("List of files in the Data directory: ");
            Console.WriteLine();
            string directoryPath = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data";
            string[] allFiles = Directory.GetFiles(directoryPath, "*.*");

            foreach (string file in allFiles)
            {
                string fileName = new FileInfo(file).Name;
                string fileCreateionDate = new FileInfo(file).CreationTime.ToString();
                Console.WriteLine($"{ fileName} { fileCreateionDate}");
            }
        }

        public static void DisplayFilesMyData()
        {
            Console.WriteLine();
            Console.WriteLine("List of files in the myData directory: ");
            Console.WriteLine();
            string directoryPath = @"C:\Users\Irina\source\repos\WorkingWithFiles\myData";
            string[] allFiles = Directory.GetFiles(directoryPath, "*.*");

            foreach (string file in allFiles)
            {
                string fileName = new FileInfo(file).Name;
                string fileCreateionDate = new FileInfo(file).CreationTime.ToString();
                Console.WriteLine($"{ fileName} { fileCreateionDate}");
            }
        }

        public static void MoveFile()
        {
            Console.WriteLine();
            string sourceDirectory = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data\";
            string destinationDirectory = @"C:\Users\Irina\source\repos\WorkingWithFiles\myData\";

            Console.WriteLine($"Enter the file name to be moved from Data to myData:");
            string fileName = Console.ReadLine();

            string filePath = sourceDirectory + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationDirectory + fileName + ".txt");
                Console.WriteLine($"File {fileName} has been moved to a myData directory.");
                DisplayFilesMyData();
            }
            else
            {
                Console.WriteLine($"{fileName} not found in Data.");
            }

            Continuation();
        }

        public static void DeleteFile()
        {
            Console.WriteLine();
            string fileName = Console.ReadLine();

            string sourcePath = @"C:\Users\Irina\source\repos\WorkingWithFiles\Data\";
            string filePath = sourcePath + fileName + ".txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File {fileName}.txt has been deleted.");
            }
            else
            {
                Console.WriteLine($"File {fileName}.txt was not found.");
            }

            DisplayFilesData();
            Continuation();
        }

        public static void Continuation()
        {
            Console.WriteLine();
            Console.WriteLine("Press [Y] to continue, Press [N] to end:");
            char operation = Convert.ToChar(Console.ReadLine().ToLower().ToUpper());

            switch (operation)
            {
                case 'Y':
                    OperationSelection();
                    break;
                case 'N':
                    Sentiment();
                    break;
                default:
                    break;
            }

        }

        public static void Sentiment()
        {
            Console.WriteLine();
            Console.WriteLine("Have a nice day!");
        }


    }


}
