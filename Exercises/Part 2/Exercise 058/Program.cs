using System;

namespace exercise_58
{
    /*
        Exercise_58
        Define a two-parameter method Smallest that returns the smaller
        of the two numbers passed to it as parameters.
        public static int Smallest(int number1, int number2) 
        {
          // write your code here
          // do not print anything inside the method

          // there must be a return command at the end
        }

        public static void Main(string[] args) 
        {
          int answer =  Smallest(2, 7);
          Console.WriteLine("Smallest: " + answer);
        }
        The output of the program:

        Smallest: 2
    */
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }
    public static int Smallest(int number1, int number2)
    {
            if(number1 > number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
    }
  }
}
