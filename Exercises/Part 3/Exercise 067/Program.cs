using System;
using System.Collections.Generic;

namespace exercise_67
{
    /*
        Exercise_67
        In the exercise template there is a program that reads inputs from the user and adds them to a list.
        Reading is stopped once the user enters an empty string.

        Modify the program to print both the first and the last values after the reading ends.
        You may suppose that at least two values are read into the list.

        > Tom 
        > Emma 
        > Alex 
        > Mary
        >
        Tom
        Mary
        > Juno 
        > Elizabeth 
        > Mason 
        > Irene
        > Olivia
        > Liam
        > Ida
        > Christopher
        > Mark
        > Sylvester
        > Oscar
        >
        Juno
        Oscar
        > Tom 
        > Mary
        >
        Tom
        Mary
    */
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine(list[0]);
      Console.WriteLine(list[list.Count-1]);

    }
  }
}
