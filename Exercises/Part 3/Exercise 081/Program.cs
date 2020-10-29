using System;
using System.Collections.Generic;

namespace exercise_81
{
    /*
        Exercise_81
        Complete the method public static void PrintNEatly(int[] array) in the template
        to make it print the numbers of the array it receives more nEatly.
        There should be a whitespace and a comma between each number. don't put a comma after the last number.

        Print the numbers on one line using Console.Write.

        You can try out your printing with this example:

        int[] array = {5, 1, 3, 4, 2};
        PrintNEatly(array);
        5, 1, 3, 4, 2
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your method here
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);

        }

        public static void PrintNeatly(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                if(i == array.Length-1)
                {
                    break;
                }
                result += ", ";
            }
            Console.WriteLine(result);
        }
    }
}