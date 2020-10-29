using System;
using System.Collections.Generic;

namespace exercise_74
{
    /*
        Exercise_74
        In the exercise template there is a program that reads inputs from the user until an empty string is entered.
        Add the following functionality to it: after reading the inputs one more string is requested from the user.
        The program then tell whether that string was found in the list or not.

        > Tom
        > Emma
        > Alex
        > Mary
        Search for?
        > Mary
        Mary was found!
        > Tom
        > Emma
        > Alex
        > Mary
        Search for?
        > Logan
        Logan was not found!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            string result;
            bool found = false;
            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
            }

            Console.WriteLine("Search for?");
            userInput = Console.ReadLine();

            foreach(string s in list)
            {
                if(s == userInput)
                {
                    found = true;
                }
            }
            if(found == true)
            {
                result = userInput + " was found!";
            }
            else
            {
                result = userInput + " was not found!";
            }
            Console.WriteLine(result);
        }
    }
}