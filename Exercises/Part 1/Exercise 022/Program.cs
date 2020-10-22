using System;

namespace exercise_22
{
    /*
        Exercise_22
        create a program, which asks the user for three integers and calculates their average as a double.
        Give the first number!
        > 3
        Give the second number!
        > 2
        Give the third number!
        > 1
        The average is 2.0
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            int b;
            int c;
            string userInput;
            string result;

            Console.WriteLine("Give the first number!");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the second number!");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give the third number!");
            userInput = Console.ReadLine();
            c = System.Convert.ToInt32(userInput);

            result = string.Format("{0:0.0####}", (a+b+c)/3d);

            Console.WriteLine("The average is "+result);
    }
  }
}
