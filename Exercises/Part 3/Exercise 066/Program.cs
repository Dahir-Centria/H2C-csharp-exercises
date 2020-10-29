using System;
using System.Collections.Generic;

namespace exercise_66
{
    /*
        Exercise_66
        In the exercise template there is a program that reads inputs from the user and adds them to a list.
        Reading is stopped once the user enters an empty string.

        Your task is to modify the method to print the last read value after it stops reading.
        Print the value that was read last from the list. Use the Count to help you.
        You do not have to take into consideration empty lists, you can assume that the user always gives at least one input.

        > Tom 
        > Emma 
        > Alex 
        > Mary
        >
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
        Oscar
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
      Console.WriteLine(list[list.Count-1]);
    }
  }
}
