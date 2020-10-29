using System;
using System.Collections.Generic;

namespace exercise_87
{
    /*
        Exercise_87
        Write a program, that reads user input until an empty line. For each non-empty string,
        the program splits the string by spaces and then prints the pieces that contain av, each on a new line.

        > navy blue shirt
        navy
        > Do you have a favourite flavour
        have
        favourite
        flavour
        > was that a cat
        >
        Tip! Strings have a Contains method, which tells if a string contains another string. It works like this:

        string text = "volcanologist";

        if (text.Contains("can")) 
        {
          Console.WriteLine("can was found");
        }

        if (!text.Contains("tin")) 
        {
          Console.WriteLine("tin wasn't found");
        }
        can was found 
        tin wasn't found
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;

            while (true)
            {
                string[] split;

                userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }

                split = userInput.Split(' ');

                foreach (string s in split)
                {
                    if (s.Contains("av"))
                    {
                        Console.WriteLine(s);
                    }
                }
            }

        }

    }

}