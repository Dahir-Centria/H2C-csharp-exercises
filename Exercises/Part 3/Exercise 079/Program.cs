using System;
using System.Collections.Generic;

namespace exercise_79
{
    /*
        Exercise_79
        The exercise template has already an array containing numbers.
        Complete the program to ask the user for a number to search in the array.
        If the array contains the given number, the program tells the index containing the number.
        If the array doesn't contain the given number, the program will tell the number wasn't found.

        Search for? 
        > 3 
        3 is at index 4.
        Search for? 
        > 7 
        7 is at index 7.
        Search for? 
        > 22 
        22 was not found.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[10];
            array[0] = 6;
            array[1] = 2;
            array[2] = 8;
            array[3] = 1;
            array[4] = 3;
            array[5] = 0;
            array[6] = 9;
            array[7] = 7;

            Console.WriteLine("Search for?");
            int searching = Convert.ToInt32(Console.ReadLine());

            // Implement the search functionality here
            int? index = null;
            string result;

            for (int i = 0; i < array.Length; i++)
            {
                if (searching == array[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != null)
            {
                result = searching + " is at index " + index;
            }
            else
            {
                result = searching + " was not found.";
            }
            Console.WriteLine(result);

        }

    }
}