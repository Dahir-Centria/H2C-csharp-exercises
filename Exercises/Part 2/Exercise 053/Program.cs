using System;

namespace exercise_53
{
    /*
        Exercise_53
        Write a method public static void Division(int numerator, int denominator)
        that prints the result of the division of the numerator by the denominator.
        Keep in mind that the result of the division of the integers is an integer --
        in this case we want the result to be a floating point number (double).
    */
  class Program
  {
    public static void Main(String[] args)
    {
            string userInput;
            int a;
            int b;

            Console.WriteLine("Write the numerator.");
            userInput = Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            Console.WriteLine("Write the denominator.");
            userInput = Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Division(a,b);
    }
    public static void Division(int numerator, int denominator) //Write a method public static void Division(int numerator, int denominator)
    {
            string result = "Divison result is: ";

            if(denominator == 0)
            {
                result += "undefined";
            }
            else
            {
                result += (numerator/(double)denominator).ToString();
            }

            Console.WriteLine(result); //that prints the result of the division of the numerator by the denominator.
    }
  }
}