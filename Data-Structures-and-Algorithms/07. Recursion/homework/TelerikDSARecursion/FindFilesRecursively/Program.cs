using System;
using System.IO;

namespace FindFilesRecursively
{
    public class Program
    {
        private static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                FindFiles(directory);
            }
        }
        public static void Main()
        {
            Console.WriteLine("Please enter folder path: ");
            string path = Console.ReadLine();
            FindFiles(path);
        }
    }
}
