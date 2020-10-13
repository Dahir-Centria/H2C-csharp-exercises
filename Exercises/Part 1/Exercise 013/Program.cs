using System;

namespace exercise_13
{
    /*
        Exercise_13
        create a program, that asks the user for a double. After user input, the program will print the double. Example prints:
        Give a number!
        > 11.11
        You gave 11.11
        Give a number!
        > 41.999999
        You gave 41.999999
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            double result;

            Console.WriteLine("Give a number!");
            userInput = Console.ReadLine();
            result = System.Convert.ToDouble(userInput);

            Console.WriteLine("You gave "+result);
    }
  }
}
