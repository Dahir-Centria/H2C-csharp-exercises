using System;

namespace exercise_17
{
    /*
        Exercise_17
        create a program, which asks the user for two integers, and calculates their sum.
        Remember, that the input is a string, so you have to convert it to integer!

        Example output:

        Give the first number!
        > 8
        Give the second number!
        > 3
        The sum is 11
        Give the first number!
        > 3
        Give the second number!
        > -1
        The sum is 2
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            int b;
            string userInput;

            Console.WriteLine("Give the first number!");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the second number!");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine("The sum is "+(a+b));
    }
  }
}
