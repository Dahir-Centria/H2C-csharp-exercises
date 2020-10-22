using System;

namespace exercise_21
{
    /*
        Exercise_21
        create a program, which asks the user for two integers and calculates their average as a double.
        Give the first number!
        > 3
        Give the second number!
        > 2
        The average is 2.5
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
            
            result = string.Format("{0:0.0####}", ((a+b)/2d));

            Console.WriteLine("The average is "+result);
    }
  }
}
