using System;

namespace exercise_52
{
    /*
        Exercise_52
        create the following method in the exercise template: public static void PrintFromNumberToOne(int number).
        It should print the numbers from the number passed as a parameter down to one.
        Two examples of the method's usage are given below.
        public static void Main(string[] args) 
        {
          PrintFromNumberToOne(5);
        }
        5
        4
        3
        2
        1
        public static void Main(string[] args) 
        {
          PrintFromNumberToOne(2);
        }
        2
        1
    */
  class Program
  {
    public static void Main(String[] args)
    {
        PrintFromNumberToOne(2);
    }
    public static void PrintFromNumberToOne(int number)
    {
        for(int i = number; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
  }
}
