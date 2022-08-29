using System;
using System.IO;

namespace CsharpSection9DirectoryDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/Demo/Path1/");

            //var files = Directory.GetFiles(@"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/", "*.sln", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"/Users/faysalregal/Desktop/C# Fundamentals/Section 9 Working with Files/", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");


            // DIRECTORY INFO
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();




        }
    }
}
