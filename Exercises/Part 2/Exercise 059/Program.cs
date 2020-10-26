using System;

namespace exercise_59
{
    /*
        Exercise_59
        Define a three-parameter method GrEatest that returns the grEatest
        of the three numbers passed to it as parameters.
        public static int GrEatest(int number1, int number2, int number3) 
        {
          // write your code here
          // do not print anything inside the method

          // there must be a return command at the end
        }

        public static void Main(string[] args) 
        {
          int answer =  GrEatest(2, 7, 3);
          Console.WriteLine("GrEatest: " + answer);
        }
        The output of the program:

        GrEatest: 7
        NOTICE! There has been an update to the template for exercises 60 and 61.
        The template should include empty methods for the exercise.
        IF YOU DO NOT GET THEM BY GIT PULL, JUST COPY THEM BY HAND!
    */
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }
    public static int Greatest(int number1, int number2, int number3) 
    {
            int temp = number1;

            if(temp < number2)
            {
                temp = number2;
            }
            if(temp < number3)
            {
                temp = number3;
            }

            return temp;
    }
  }
}
