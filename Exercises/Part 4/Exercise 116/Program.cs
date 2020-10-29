using System;
using System.IO;

namespace exercise_116
{
    /*
        Exercise_116
        Write a program that prints the contents of a file called "data.txt",
        such that each line of the file is printed on its own line.

        If the file content looks like so:

        In a world
        Where code is built

        Then the program should print the following:

        In a world
        Where code is built
    */
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo info = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            FileInfo[] fInfo = info.GetFiles("data.txt");

            string text = File.ReadAllText(fInfo[0].FullName);
            Console.WriteLine(text);
        }
    }
}
