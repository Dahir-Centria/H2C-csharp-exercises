using System;

namespace exercise_26
{
    /*
        Exercise_26
        create a program which asks for an integer. If the integer is less than 1900, output "You're old".
        Give your age:
        >1985
        Give your age:
        > 1899
        You're old
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int a;
            string userInput;

            Console.WriteLine("Give your age:");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            if(a < 1900)
            {
                Console.WriteLine("You're old");
            }
    }
  }
}
