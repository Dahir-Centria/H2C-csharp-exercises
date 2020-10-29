using System;
using System.Collections.Generic;


namespace exercise_62
{
    /*
        Exercise_62
        The exercise contains a base that asks the user for strings and adds them to a list. The program stops reading when the user enters an empty string. The program then prints the first element of the list.

        Your assignment is to modify the program so that instead of the first value, the third value on the list is printed. Remember that programmers start counting from zero! The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

        > Tom 
        > Emma 
        > Alex 
        > Mary
        >
        Alex
        > Emma 
        > Alex 
        > Mary
        >

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

      // BEGIN SOLUTION
      Console.WriteLine(list[2]);
      // END SOLUTION
    }

  }
}
