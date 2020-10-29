﻿using System;
using System.Collections.Generic;

namespace exercise_90
{
    /*
        Exercise_90
        Write a program that reads names and ages from the user until an empty line is entered.
        The name and age are separed by a comma.

        After reading the program prints the age of the oldest person.
        You can assume, that the user enters at least one person, and that one of the users is older than the others.

        > sebastian,2 
        > lucas,2
        > lily,1
        > hanna,5
        > gabriel,10
        >
        Age of the oldest: 10
    */
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = -1;
            int current;
            string userInput;

            while (true)
            {
                string[] split;

                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }

                split = userInput.Split(',');
                current = Convert.ToInt32(split[1]);

                if (oldest < current)
                {
                    oldest = current;
                }
            }
            Console.WriteLine("Age of the oldest: " + oldest);
        }
    }
}