using System;

namespace exercise_31
{
    /*
        Exercise_31
        create a program which asks for an integer and tells the user if it is even or not.
        Give a number:
        > 2
        It is even.
        Give a number
        > 5
        It is odd.
        Hint: You might want to use the % operator to get the remainder after a division with 2.
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            string userInput;
            string result;

            Console.WriteLine("Give a number:");
            userInput = Console.ReadLine();
            a = (System.Convert.ToInt32(userInput))%2;

            if(a == 0)
            {
                result = "It is even.";
            }
            else
            {
                result = "It is odd.";
            }
            Console.WriteLine(result);
    }
  }
}
