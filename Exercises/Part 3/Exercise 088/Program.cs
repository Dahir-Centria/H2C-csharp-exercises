using System;
using System.Collections.Generic;

namespace exercise_88
{
    /*
        Exercise_88
        Write a program, that reads user input until an empty line.
        For each non-empty line the program splits the string by spaces and prints the first part of the string.

        > one two three four 
        one 
        > this is a very important message 
        this
        >
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
                Console.WriteLine(split[0]);
            }
        }
    }
}