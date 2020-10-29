using System;
using System.Collections.Generic;

namespace exercise_72
{
    /*
        Exercise_72
        Write a program that reads numbers from the user. When number 9999 is entered, the reading process stops.
        After this the program will print the smallest number in the list, and also the indices where that number is found.
        Notice: the smallest number can appear multiple times in the list.

        > 72
        > 2
        > 8
        > 8
        > 11
        > 9999
        Smallest number: 2 
        Found at index: 1
        > 72
        > 44
        > 8
        > 8
        > 11
        > 9999
        Smallest number: 8 
        Found at index: 2 
        Found at index: 3
        HINT: combine the programs you wrote for the exercises
        "GrEatest number in the list" and "Index of the requested number".
        First find the smalleest number, and then find the index of that number.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int a;
            int smallestNumber = 0;
            List<int> numbers = new List<int>();

            while(true)
            {
                userInput = Console.ReadLine();
                a = Convert.ToInt32(userInput);

                if(a == 9999)
                {
                    break;
                }
                if(numbers.Count == 0)
                {
                    smallestNumber = a;
                }

                if(numbers.Count == 0 || smallestNumber > a)
                {
                    smallestNumber = a;
                }
                numbers.Add(a);
            }

            Console.WriteLine("Smallest number: " + smallestNumber);
            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == smallestNumber)
                {
                    Console.WriteLine("Found at index: " + i);
                }
            }
        }
    }
}