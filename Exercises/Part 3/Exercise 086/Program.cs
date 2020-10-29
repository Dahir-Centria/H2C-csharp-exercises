using System;
using System.Collections.Generic;

namespace exercise_86
{
    /*
    Exercise_86
    Write a program that reads strings from the user.
    If the input is empty, the program stops reading input and halts.
    For each non-empty input it splits the string input by whitespaces and prints each part of the string on a new line.

    > once upon a time 
    once 
    upon 
    a 
    time 
    > a little program 
    a 
    little 
    program 
    > halted 
    halted
    >
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            string[] result;
            
            while(true)
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }

                result = userInput.Split(' ');

                foreach (string s in result)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}