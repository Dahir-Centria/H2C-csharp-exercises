using System;

namespace exercise_15
{
    /*
        Exercise_15
        Let's combine everything you know so far. create program that asks the user for a string, an integer, a double and a boolean, and prints them like follows:
        Give a string:
        > This is a masterpiece!
        Give an integer:
        > 42
        Give a double:
        > 3.1415
        Give a boolean:
        > True
        Your string: This is a masterpiece!
        Your integer: 42
        Your double: 3.1415
        Your boolean: True
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            string resultText;
            int resultInteger;
            double resultDouble;
            bool resultBoolean;

            Console.WriteLine("Give a string:");
            userInput = Console.ReadLine();
            resultText = userInput;

            Console.WriteLine("Give an integer:");
            userInput = Console.ReadLine();
            resultInteger = System.Convert.ToInt32(userInput);

            Console.WriteLine("Give a double:");
            userInput = Console.ReadLine();
            resultDouble = System.Convert.ToDouble(userInput);

            Console.WriteLine("Give a boolean:");
            userInput = Console.ReadLine();
            resultBoolean = System.Convert.ToBoolean(userInput);

            Console.WriteLine("Your string: "+resultText);
            Console.WriteLine("Your integer: "+resultInteger);
            Console.WriteLine("Your double: "+resultDouble);
            Console.WriteLine("Your boolean: "+resultBoolean);
    }
  }
}
