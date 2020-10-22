using System;

namespace exercise_29
{
    /*
        Exercise_29
        create a program which asks for two integers. The program should tell which of them is grEater. If they are equal, that should be noted, too.
        Give the first number!
        > 3
        Give the second number!
        > 2
        The larger number is 3!
        Give the first number!
        > 3
        Give the second number!
        > 4
        The larger number is 4!
        Give the first number!
        > 3
        Give the second number!
        > 3
        They are equal!
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

            if(a > b)
            {
                result = "The larger number is "+a+"!";
            }
            else if(b > a)
            {
                result = "The larger number is "+b+"!";
            }
            else
            {
                result = "They are equal!";
            }

            Console.WriteLine(result);
    }
  }
}
