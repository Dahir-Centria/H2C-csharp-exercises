using System;

namespace exercise_12
{
    /*
        Exercise_12
        create a program, that asks the user for an integer. After user input, the program will print the integer. Example prints:
        Give a number!
        > 11
        You gave 11
        Give a number!
        > 42
        You gave 42
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int result;

            Console.WriteLine("Give a number!");
            userInput = Console.ReadLine();
            result = System.Convert.ToInt32(userInput);

            Console.WriteLine("You gave "+result);
    }
  }
}
