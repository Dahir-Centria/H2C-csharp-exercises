using System;
using System.Collections.Generic;

namespace exercise_92
{
    /*
    Exercise_92
    In this exercise you'll be asked for the length of the names.
    You can find out the length of a string with Length property:

    string word = "equisterian";
    int length = word.Length;
    Console.WriteLine("The length of the word " + word + " is " + length);
    The length of the word equisterian is 11
    Write a program that reads names and birth years from the user until an empty line is entered.
    The name and birth year are separed by a comma.

    After that the program prints the longest name and the highest age.
    If multiple names are equally longest, you can print any of them.
    You can assume the user to enter at least one person,and the current year to be 2020.

    > sebastian,2017 
    > lucas,2017 
    > lily,2017 
    > hanna,2014 
    > gabriel,2009
    >
    Longest name: sebastian 
    Highest age: 11
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int highestAge = -1;
            string longestName = "";

            while (true)
            {
                string[] split;

                int currentAge;
                string currentName;

                userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }

                split = userInput.Split(',');
                currentName = split[0];
                currentAge = 2020 - Convert.ToInt32(split[1]);

                if (highestAge < currentAge)
                {
                    highestAge = currentAge;
                }
                if(longestName.Length < currentName.Length)
                {
                    longestName = currentName;
                }
            }

            Console.WriteLine("Longest name: " + longestName);
            Console.WriteLine("Highest age: " + highestAge);
        }
    }
}