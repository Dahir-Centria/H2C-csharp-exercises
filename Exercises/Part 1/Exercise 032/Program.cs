using System;

namespace exercise_32
{
    /*
        Exercise_32
        create a program which asks for a string. If the string is "Mellon", print "Welcome, friend", otherwise print "They've got a cave troll!"
        Speak, friend, and enter!
        > Let meeeee in!
        They've got a cave troll!
        Speak, friend, and enter!
        > Mellon
        Welcome, friend
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string a;
            string userInput;
            string result;

            Console.WriteLine("Speak, friend, and enter!");
            userInput = Console.ReadLine();
            a = userInput;

            if(a == "Mellon")
            {
                result = "Welcome, friend";
            }
            else
            {
                result = "They've got a cave troll!";
            }
            
            Console.WriteLine(result);
    }
  }
}