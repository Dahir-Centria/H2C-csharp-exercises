using System;
using System.Collections.Generic;

namespace exercise_64
{
    /*
        Exercise_64
        There is a program that uses a list in the exercise template.
        Modify it so that its execution always produces the error ArgumentOutRangeException.
        The user should not have to give any inputs to the program (e.g. write something on the keyboard)
    */
  class Program
  {
    public static void Main(string[] args)
    {
      // Modify this program to cause an ArgumentOutOfRangeException 

      // Thanks to Sairam Gudiseva for the essay!
      List<string> lines = new List<string>();
      lines[-1] = "";
      lines.Add("Never has a man influenced physics so profoundly as Niels Bohr in the early 1900's");
      lines.Add("Going back to this time period, little was known about atomic structure; Bohr set out");
      lines.Add("to end the obscurity of physics. However, things didn't come easy for Bohr. He had to");
      lines.Add("give up most of his life for physics and research of many hypothesis. But, this is why");
      lines.Add("you and I have even heard of the quantum theory and atomic structures. Bohr came");
      lines.Add("up with his quantum theory while studying...");

      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }

    }

  }
}
