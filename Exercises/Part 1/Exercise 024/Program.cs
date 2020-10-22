using System;

namespace exercise_24
{
    /*
        Exercise_24
        create a program, which asks the user for an integer.
        If the given integer is larger than 120, output "Speeding!".

        Your speed:
        > 5
        Your speed:
        125
        Speeding!
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            string userInput;

            Console.WriteLine("Your speed:");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            if(a > 120)
            {
                Console.WriteLine("Speeding!");
            }
    }
  }
}