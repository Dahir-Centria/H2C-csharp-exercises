using System;
using System.Collections.Generic;

namespace exercise_73
{
    /*
        Exercise_73
        The exercise template reads numbers from the user and adds them to a list.
        Reading is stopped once the user enters the number -1.

        Modify the program so that after reading the numbers it calculates and prints the sum of the numbers in the list.

        > 72
        > 2
        > 8
        > 11
        > -1
        Sum: 93
    */
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                if(list.Count == 0)
                {
                    sum = input;
                }
                else
                {
                    sum += input;
                }
                list.Add(input);
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}