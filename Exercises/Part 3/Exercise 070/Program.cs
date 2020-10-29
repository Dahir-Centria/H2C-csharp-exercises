using System;
using System.Collections.Generic;

namespace exercise_70
{
    /*
        Exercise_70
        The exercise template contains a base that reads numbers from the user and adds them to a list.
        Reading is stopped once the user enters the number -1.

        Continue developing the program so that it ends the grEatest number in the list and prints its value after reading all the numbers.
        The programming should work in the following manner.

        > 72
        > 2
        > 8
        > 93
        > 11
        > -1
        The grEatest number: 93
        You can assume that user always gives atleast one viable number.

        You can use the source code below as an inspitation. It is used to find the smallest number.

        // assume we have a list that contains integers

        int smallest = list[0];

        for(int i = 0; i < list.Count; i++) {
            int number = list[i];
            if (smallest > number) {
                smallest = number;
            }
        }

        Console.WriteLine("The smallest number: " + smallest);
    */
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int greatest = -1;

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }

                //track the index of greatest object in list.
                if(greatest == -1 || list[greatest] < input)
                {
                    greatest = list.Count;
                }
                list.Add(input);
            }

            Console.WriteLine("The greatest number: " + list[greatest]);
        }
    }
}
