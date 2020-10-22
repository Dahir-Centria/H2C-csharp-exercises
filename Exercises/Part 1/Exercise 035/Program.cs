using System;

namespace exercise_35
{
    /*
        Exercise_35
        create a program, which asks the user for integers, until the user give the number "42".
        Give a number:
        > 41
        Give a number:
        > 68
        Give a number:
        -42
        Give a number:
        42
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a = 0;

            while(a != 42)
            {
                Console.WriteLine("Give a number:");
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);
            }
    }
  }
}
