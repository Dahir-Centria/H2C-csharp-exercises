using System;

namespace exercise_41
{
    /*
        Exercise_41
        Write a program that reads an integer from the user input, and then prints the second power of the given integer, i.e.
        the integer multiplied by itself.
        > 4
        16
        > 5
        25
        > -3
        9
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine(a*a);
    }
  }
}
