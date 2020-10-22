using System;

namespace exercise_33
{
    /*
        Exercise_33
        create a program which asks for two string. If the strings are equal, print "Echo", otherwise print "Nope".
        Give the first string:
        > Potato
        Give the second string:
        > Potato
        Echo!
        Give the first string:
        > Potato
        Give the second string:
        > Tomato
        Nope!
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string a;
            string b;
            string userInput;
            string result;

            Console.WriteLine("Give the first string:");
            userInput = Console.ReadLine();
            a = userInput;

            Console.WriteLine("Give the second string:");
            userInput = Console.ReadLine();
            b = userInput;

            if(a == b)
            {
                result = "Echo!";
            }
            else
            {
                result = "Nope!";
            }
            
            Console.WriteLine(result);
    }
  }
}
