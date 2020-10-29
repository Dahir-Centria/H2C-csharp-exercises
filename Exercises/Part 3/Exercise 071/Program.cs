using System;
using System.Collections.Generic;

namespace exercise_71
{
    /*
        Exercise_71
        The exercise template reads numbers from the user and adds them to a list.
        Reading is stopped once the user enters the number -1.

        Expand the program that then asks the user for a number, and reports that number's index in the list.
        If the number is not found, the program should not print anything.

        > 72 
        > 2 
        > 8 
        > 8 
        > 11 
        > -1
        Search for? 
        > 2 
        2 is at index 1
        > 72 
        > 2 
        > 8 
        > 8 
        > 11 
        > -1
        Search for? 
        > 8 
        8 is at index 2
        8 is at index 3
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int value = -1;
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }

            Console.WriteLine("Search for?");
            userInput = Console.ReadLine();
            value = Convert.ToInt32(userInput);

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == value)
                {
                    Console.WriteLine(value + " is at index " + i);
                }
            }
        }
    }
}