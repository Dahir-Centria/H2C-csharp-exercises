using System;

namespace exercise_43
{
    /*
        Exercise_43
        Write a program, that reads an integer from the user. If the number is less than 0, it prints the number multiplied by -1.
        Otherwise the program prints the number itself. A few examples of the expected function below:
        > -3
        3
        > 1
        1
        > 0
        0
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            if(a < 0)
            {
                a *= -1;
            }

            Console.WriteLine(a);
    }
  }
}
