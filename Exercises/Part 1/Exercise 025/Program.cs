using System;

namespace exercise_25
{
    /*
        Exercise_25
        create a program which asks for an integer. If the integer is 1984, output "Orwell".
        Give a number:
        >1985
        Give a number:
        > 1984
        Orwell
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            string userInput;

            Console.WriteLine("Give a number:");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);
            if(a == 1984)
            {
                Console.WriteLine("Orwell");
            }
    }
  }
}
