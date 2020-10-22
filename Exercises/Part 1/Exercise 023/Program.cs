using System;

namespace exercise_23
{
    /*
        Exercise_23
        Let's create a program, that does all the basic calculations from user input! Ask for two integers and do the calculations with them.
        Give the first number!
        > 3
        Give the second number!
        > 2
        3 + 2 = 5
        3 - 2 = 1
        3 * 2 = 6
        3 / 2 = 1.5
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            int b;
            string userInput;
            string result;

            Console.WriteLine("Give the first number!");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the second number!");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine(a+" + "+b+" = "+(a+b));
            Console.WriteLine(a+" - "+b+" = "+(a-b));
            Console.WriteLine(a+" * "+b+" = "+(a*b));
            Console.WriteLine(a+" / "+b+" = "+(a/(double)b));
    }
  }
}
