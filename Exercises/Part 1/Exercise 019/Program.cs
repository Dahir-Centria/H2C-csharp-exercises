using System;

namespace exercise_19
{
    /*
        Exercise_19
        create a program, which asks the user for two integers and counts their sum. This time, also print the equation to the user, too.
        Give the first number!
        > 3
        Give the second number!
        > 1
        3 + 1 = 4
        Give the first number!
        > 5
        Give the second number!
        > -1
        3 + -1 = 2
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

            Console.WriteLine(a+" + "+b+" = "+(a+b));
    }
  }
}
