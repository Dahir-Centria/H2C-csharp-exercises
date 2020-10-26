using System;

namespace exercise_50
{
    /*
        Exercise_50
        Expand the previous program so that the main program asks the user for the number of times the phrase will be printed
        (i.e. how many times the method will be called).
        public static void Main(string[] args)
        {
          // ask the user for the number of times that the phrase will be printed
          // use the while command to call the method a suitable number of times

        }

        // Write your method here:
        public static void PrintPhrase() 
        {

        }
        How many times?
        > 3
        In a hole in the ground there lived a method
        In a hole in the ground there lived a method
        In a hole in the ground there lived a method
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;

            Console.WriteLine("How many times?");
            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            while(a > 0)
            {
                PrintPhrase();
                a--;
            }
    }

    public static void PrintPhrase()
    {
            Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
