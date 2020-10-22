using System;

namespace exercise_28
{
    /*
        Exercise_28
        create a program which tell if the given person is legally adult (in Finland, over 18), or not.
        How old are you?
        > 5
        You're under age!
        How old are you?
        > 18
        You're an adult!
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            string userInput;
            string result;

            Console.WriteLine("How old are you?");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            if(a < 18)
            {
                result = "You're under age!";
            }
            else
            {
                result = "You're an adult!";
            }

            Console.WriteLine(result);
    }
  }
}
