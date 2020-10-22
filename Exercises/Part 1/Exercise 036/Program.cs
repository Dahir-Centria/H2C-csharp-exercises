using System;

namespace exercise_36
{
    /*
        Exercise_36
        create a program, which asks the user for integers. If the number is zero, exit the program. If the number is negative, give the user message "That is negative". If the number is positive, output the number, raised to its second power (the number multiplied with itself).
        Give a number:
        > 5
        25
        Give a number:
        > -2
        That is negative
        Give a number:
        > 4
        16
        Give a number:
        0
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            string result;
            double a;

            for(int i = 0; i == 0;)
            {
                Console.WriteLine("Give a number:");
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);

                if(a == 0)
                {
                    break;
                }

                if(a > 0)
                {
                    result = (a*a).ToString();
                }
                else
                {
                    result = "That is negative";
                }

                Console.WriteLine(result);
            }
    }
  }
}
