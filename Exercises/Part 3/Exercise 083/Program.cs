using System;
using System.Collections.Generic;

namespace exercise_83
{
    /*
        Exercise_83
        Write a program, that reads a string from the user and then prints it three times.

        Give a word: cake

        cakecakecake
        NOTICE! The program should ask for only one string. Don't use a loop here.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;

            Console.Write("Give a word: ");
            userInput = Console.ReadLine();
            Console.WriteLine("\n"+userInput+userInput+userInput);
        }

    }
}