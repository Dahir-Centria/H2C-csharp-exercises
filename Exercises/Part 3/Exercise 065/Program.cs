using System;
using System.Collections.Generic;

namespace exercise_65
{
    /*
        Exercise_65
        In the exercise template is a program that reads input from the user.
        Modify its working so that when the program quits reading (with an empty line),
        the program prints the number of values on the list.

        > Tom 
        > Emma 
        > Alex 
        > Mary
        >
        In total: 4
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
        In total: 11
        Notice! Be sure to use the Count property of the list.

        The next exercises are meant for learning to use lists and indices.
        Even if you could complete the execises without a list, concentrate on training to use lists.
        The functionality in the exercises is to be implemented after reading the inputs.
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
      Console.WriteLine("In total: "+list.Count);
    }
  }
}
