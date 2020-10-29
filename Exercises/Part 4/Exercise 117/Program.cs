﻿using System;
using System.IO;

namespace exercise_117
{
    /*
    Exercise_117
    Write a program that asks the user for a string, and then prints the 
    contents of a file with a name matching the string provided. You may 
    assume that the user provides a file name that the program can find. 
    You do not have to worry about getting errors when the file does not 
    exist.

    The exercise template contains the files "data.txt" and "song.txt", 
    which you may use when testing the functionality of your program. The
    output of the program can be seen below for when a user has entered 
    the string "song.txt". The content that is printed comes from the file
    "song.txt". Naturally, the program should also work with other filenames
    , assuming the file can be found.

    Which file should have its contents printed? 
    > song.txt 

    No option for duality 
    The old is where we come 
    Clockspeed is fast, but we'll survive 
    The new will overcome 
    We are challengers, not followers 
    We take the ball to build 
    Easy safe services 
    Are here to stay

    Value for society 
    Value for life 
    For you and me 
    Tieto is here allright!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo info = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            string userInput;
            Console.WriteLine("Which file should have its contents printed?");
            userInput = Console.ReadLine();
            Console.WriteLine("");
            FileInfo[] fInfo = info.GetFiles(userInput);

            string text = File.ReadAllText(fInfo[0].FullName);
            Console.WriteLine(text);
        }
    }
}