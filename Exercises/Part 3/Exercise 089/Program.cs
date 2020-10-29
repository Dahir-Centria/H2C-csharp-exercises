using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_89
{
    /*
        Exercise_89
        Write a program, that reads user input until an empty line.
        For each non-empty line the program splits the string by spaces and prints the last part of the string.

        > one two three four 
        four 
        > this is a very important message 
        message
        >
        Tip! You can find out the length of the array like this:

        string[] parts = {"one", "two", "three"};
        Console.WriteLine("Number of parts: " + parts.Length);
        Number of parts: 3
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            while(true)
            {
                string[] split;

                userInput = Console.ReadLine();

                if(userInput == "")
                {
                    break;
                }

                split = userInput.Split(' ');
                Console.WriteLine(split[split.Length - 1]);
            }
        }
    }
}