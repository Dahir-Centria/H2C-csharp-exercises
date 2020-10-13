using System;

namespace exercise_18
{
    /*
        Exercise_18
        Expand a little on the previous exercise. Now create a program, which asks for three integers, and calculates their sum.
        Give the first number!
        > 3
        Give the second number!
        > -1
        Give the third number!
        > 2
        The sum is 4
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            int b;
            int c;
            string userInput;

            Console.WriteLine("Give the first number!");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the second number!");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the third number!");
            userInput = Console.ReadLine();
            c = System.Convert.ToInt32(userInput);

            Console.WriteLine("The sum is "+(a+b+c));
    }
  }
}
