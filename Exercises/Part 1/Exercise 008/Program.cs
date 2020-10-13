using System;

namespace exercise_08
{
    /*
        Exercise_08
        create a program, that asks user for their name and greets them. Example output with Ada as input:
        What is your name?
        > Ada
        Hello Ada!
        Notice the exclamation mark.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("What is your name?");
            userInput = Console.ReadLine();
            Console.WriteLine("Hello "+userInput+"!");
        }
    }
}
