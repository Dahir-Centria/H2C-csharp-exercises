using System;

namespace exercise_51
{
    /*
        Exercise_51
        create the following method in the exercise template: public static void PrintUntilNumber(int number).
        It should print the numbers from one to the number passed as a parameter.
        Two examples of the method's usage are given below.
        public static void Main(string[] args) 
        {
          PrintUntilNumber(5);
        }
        1
        2
        3
        4
        5
        public static void Main(string[] args) 
        {
          PrintUntilNumber(3);
        }
        1
        2
        3
    */
  class Program
  {
    public static void Main(String[] args)
    {
            PrintUntilNumber(3);
    }
    public static void PrintUntilNumber(int number)
    {
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
    }
  }
}
