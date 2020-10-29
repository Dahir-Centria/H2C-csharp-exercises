using System;
using System.Collections.Generic;

namespace exercise_78
{
    /*
        Exercise_78
        The exercise template already contains a program, that creates an array and 
        prints the values of the array twice.
        Modify the program to do following: After the first printing, the program 
        should ask for two indices from the user.
        The values in these two indices should be swapped, and in the end the values
        of the array should be printed once again.

        1 
        3 
        5 
        7 
        9

        Give two indices to swap: 
        > 2 
        > 4

        1 
        3 
        9 
        7 
        5

        1 
        3 
        5 
        7 
        9

        Give two indices to swap: 
        > 0 
        > 1

        3 
        1 
        5 
        7 
        9
        You can assume the array to contain the given indices.

        Tip! You'll need an additional variable to store one of the values for little while.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
            Console.WriteLine("");

            // Implement here
            // asking for the two indices
            // and then swapping them
            string userInput;
            int a;
            int b;
            int temp;

            Console.WriteLine("Give two indices to swap:");

            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            userInput = Console.ReadLine();
            b = Convert.ToInt32(userInput);

            temp = array[a];
            array[a] = array[b];
            array[b] = temp;

            // DO NOT CHANGE THE FOLLOWING CODE!
            Console.WriteLine("");
            index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }

    }
}