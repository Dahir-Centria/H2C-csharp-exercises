using System;

namespace exercise_45
{
    /*
        Exercise_45
        Write a program that reads an integer from the user.
        Then the program prints numbers from 0 to the number given by the user.
        You can assume that the user always gives a positive number. Below is some examples of the wanted functionality.
        You can use either a while-loop with a condition, or a for-loop.
        > 4
        0
        1
        2
        3
        4
        > 1
        0
        1
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            for(int result = 0; result <= a; result++)
            {
                Console.WriteLine(result);
            }
    }
  }
}
