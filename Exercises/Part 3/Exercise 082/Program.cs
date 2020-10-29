using System;
using System.Collections.Generic;

namespace exercise_82
{
    /*
        Exercise_82
        Complete the method public static void PrintArrayInStars(int[] array) in the template
        to make it print a row of stars for each number in the array.
        The amount of stars on each row is defined by the corresponding number in the array.

        You can try out the printing with this example:

        int[] array = {5, 1, 3, 4, 2};
        PrintArrayInStars(array);
        ***** 
        * 
        *** 
        **** 
        **
        The 0th element of the array is 5, so the first line has 5 stars. The next one has 1 etc.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your method here
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);

        }

        public static void PrintArrayInStars(int[] array)
        {
            foreach(int n in array)
            {
                string result = "";
                for(int i = 0; i < n; i++)
                {
                    result += "*";
                }
                Console.WriteLine(result);
            }
        }
    }
}