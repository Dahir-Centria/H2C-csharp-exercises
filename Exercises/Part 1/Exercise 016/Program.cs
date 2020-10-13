using System;

namespace exercise_16
{
    /*
        Exercise_16
        create a program, which asks user for amount of days, and prints the total amount of seconds for that amount of days, gives the answer and quits.

        Example print:

        How many days?
        > 2
        172800
        How many days?
        > 7
        604800
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int result;
            string userInput;

            Console.WriteLine("How many days?");
            userInput = Console.ReadLine();
            result = System.Convert.ToInt32(userInput)*24*60*60;

            Console.WriteLine(result);
    }
  }
}
