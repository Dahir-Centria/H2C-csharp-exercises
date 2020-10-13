using System;

namespace exercise_20
{
    /*
        Exercise_20
        create a program, which asks the user for two integers and multiplies them with each other.
        Give the first number!
        > 3
        Give the second number!
        > 2
        3 * 2 = 6
        Give the first number!
        > 50
        Give the second number!
        > -2
        50  * -2 = -100
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

            Console.WriteLine(a+" * "+b+" = "+(a*b));
    }
  }
}
