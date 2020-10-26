using System;

namespace exercise_42
{
    /*
        Exercise_42
        Write a program that reads two integers from the user, and prints the square root of the sum of these integers.
        The program does not need to work with negative values.
        You can get the square root of an integer with the command Math.Sqrt like this:

        int number = 42;
        double squareRoot = Math.Sqrt(number);
        Console.WriteLine(squareRoot);
        > 1 
        > 0 
        1
        > 5 
        > 4 
        3
        > 1 
        > 35 
        6
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;
            int b;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            userInput =  Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine(Math.Sqrt(a+b));
    }
  }
}
