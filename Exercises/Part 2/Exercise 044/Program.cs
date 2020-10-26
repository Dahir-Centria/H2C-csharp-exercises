using System;

namespace exercise_44
{
    /*
        Exercise_44
        Write a program that reads two integers from the user input.
        If the first number is grEater than the second, the program prints "(first) is grEater than (second)."
        If the first number is less than the second, the program prints "(first) is less than (second)."
        Otherwise the program prints "(first) is equal to (second)."
        The (first) and (second) should always be replaced with the actual numbers given by the user.
        A few examples of the expected behaviour:

        > 8 
        > 4 
        8 is grEater than 4.
        > -3 
        > 5 
        -3 is less than 5.
        > 1 
        > 1 
        1 is equal to 1.
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;
            int b;
            string result;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            userInput =  Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            if(a > b)
            {
                result = a+" is grEater than "+b+".";
            }
            else if(b > a)
            {
                result = a+" is less than "+b+".";
            }
            else
            {
                result = a+" is equal to "+b+".";
            }

            Console.WriteLine(result);
    }
  }
}
