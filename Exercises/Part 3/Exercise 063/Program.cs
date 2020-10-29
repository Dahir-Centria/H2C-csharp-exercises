using System;
using System.Collections.Generic;


namespace exercise_63
{
    /*
        Exercise_63
        In the exercise template there is a program that reads integers from the user and adds them to a list. This ends when the user enters 0. The program then prints the first value on the list.

        Modify the program so that instead of the first value, the program prints the sum of the second and third numbers. The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

        > 1 
        > 3 
        > 5 
        > 7 
        > 0 
        8
        > 2 
        > 3 
        > 4 
        > 0 
        7
    */
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
          break;
        }

        list.Add(input);
      }
      Console.WriteLine(list[1]+list[2]);
    }

  }
}
