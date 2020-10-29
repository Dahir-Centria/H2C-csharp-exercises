using System;
using System.Collections.Generic;

namespace exercise_69
{
    /*
        Exercise_69
        The exercise template contains a base that reads numbers from the user and adds them to a list.
        Reading is stopped once the user enters the number -1.

        Expand the program to ask for a start and end indices once it has finished asking for numbers.
        After this the program shall prints all the numbers in the list that fall in the specified range
        (between the indices given by the user, inclusive).
        You may assume that the user gives indices that match some numbers in the list.

        > 72
        > 2
        > 8
        > 11
        > -1 
        From where?
        > 1
        Where to?
        > 9 
        2 
        8
        > 72
        > 2
        > 8
        > 11
        > -1 
        From where?
        > 0 
        Where to?
        > 20  
        2
        8
        11 
    */

    //I switched the writing format to speed up things, functionality stays as expected.
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int a;
            int b;

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

            Console.WriteLine("From where?");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);

            Console.WriteLine("Where to?");
            userInput = Console.ReadLine();
            b = Convert.ToInt32(userInput);

            foreach(int n in list)
            {
                if(n >= a && n <= b)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}