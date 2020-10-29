using System;
using System.Collections.Generic;

namespace exercise_84
{
    /*
        Exercise_84
        Write a program that asks the user for a string. If the user writes the string "true",
        the program prints "You got it right!", otherwise it prints "Try again!".

        Give a string: true 
        You got it right!
        Give a string: trueish 
        Try again!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string result;
            string userInput;
            Console.Write("Give a string: ");
            userInput = Console.ReadLine();
            if(userInput == "true")
            {
                result = "You got it right!";
            }
            else
            {
                result = "Try again!";
            }
            Console.WriteLine(result);
        }
    }
}