using System;

namespace exercise_34
{
    /*
        Exercise_34
        create a program which asks the user if they want to continue. If the user answers "no", then quit the program. Otherwise, ask again.
        Hint: Use a while-loop!

        Do you want to continue?
        > Yes
        Do you want to continue?
        > Hot potato
        Do you want to continue?
        > no
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput = "";

            while(userInput != "no")
            {
                Console.WriteLine("Do you want to continue?");
                userInput = Console.ReadLine();
            }
    }
  }
}
