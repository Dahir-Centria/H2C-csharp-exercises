using System;
using System.Collections.Generic;

namespace exercise_68
{
    /*
        Exercise_68
        The exercise template contains a base that reads numbers from the user and adds them to a list.
        Reading is stopped once the user enters the number -1.

        Expand the functionality of the program so that after reading the numbers, it prints all the numbers received from the user.
        The number used to indicate stopping should not be printed.

        > 72
        > 2
        > 8
        > 11
        > -1 
        72
        2
        8
        11
    */
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      foreach(int n in list)
      {
        Console.WriteLine(n);
      }
    }
  }
}
