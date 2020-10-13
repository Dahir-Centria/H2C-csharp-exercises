using System;

namespace exercise_14
{
    /*
        Exercise_14
        create a program, that asks the user for a boolean. After user input, the program will print the boolean. Example prints:
        Give me the truth!
        > tRuE
        True
        Give me the truth!
        > false
        False
    */
  class Program
  {
    public static void Main(string[] args)
    {
      string userInput;
      bool result;

      Console.WriteLine("Give me the truth!");
      userInput = Console.ReadLine();
      result = System.Convert.ToBoolean(userInput);

      Console.WriteLine(result);
    }
  }
}
