using System;

namespace exercise_54
{
    /*
        Exercise_54
        Write a method public static void DivisibleByThreeInRange(int beginning, int end)
        that prints all the numbers divisible by three in the given range.
        The numbers are to be printed in order from the smallest to the grEatest.
    */
  class Program
  {
    public static void Main(String[] args)
    {
            string userInput;
            int a;
            int b;

            Console.WriteLine("I am going to list numbers that are divisible by 3 in given range.");
            Console.WriteLine("Write the starting number.");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Write the finishing number.");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            DivisibleByThreeInRange(a,b);
    }
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
        while(beginning <= end)//would be 3 times faster if we just used add 3 method, but since n/3 is still n i will use modulo instead.
        {
                if(beginning%3 == 0)
                {
                    Console.WriteLine(beginning);
                }
                beginning++;
        }
    }
  }
}
