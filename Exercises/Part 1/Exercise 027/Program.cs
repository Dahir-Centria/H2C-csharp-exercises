using System;

namespace exercise_27
{
    /*
        Exercise_27
        create a program which tells if the given number is positive (grEater than zero), or not.
        Give a number:
        > 5
        It is positive
        Give a number:
        -2
        It is not positive
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
            a = System.Convert.ToInt32(userInput);

            if(a > 0)
            {
                result = "It is positive";
            }
            else
            {
                result = "It is not positive";
            }

            Console.WriteLine(result);
    }
  }
}
