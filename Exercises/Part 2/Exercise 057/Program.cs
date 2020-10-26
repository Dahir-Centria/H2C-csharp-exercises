using System;

namespace exercise_57
{
    /*
        Exercise_57
        Expand the method Sum in the exercise template so that it calculates
        and returns the sum of the numbers that are given as the parameters.
        create the method using the following structure:

        public static int Sum(int number1, int number2, int number3, int number4) 
        {
          // write your code here
          // remember to include return (at the end)!
        }

        public static void Main(string[] args) 
        {
            int answer = Sum(4, 3, 6, 1);
            Console.WriteLine("Sum: " + answer);
        }
        Output of the example:

        Sum: 14
    */
  class Program
  {
    public static int Sum(int number1, int number2, int number3, int number4)
    {
      return number1+number2+number3+number4;
    }

    public static void Main(String[] args)
    {
      int answer = Sum(4, 3, 6, 1);
      Console.WriteLine("Sum: " + answer);
    }
  }
}
