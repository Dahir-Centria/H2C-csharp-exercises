using System;

namespace exercise_11
{
    /*
        Exercise_11
        The exercise comes with a template that prints the following:
        Days to summer:
        100
        Hours to lunch:
        1
        Coding is fun:
        Are you sure?
        Change the values of the variables, so the program will print

        Days to summer:
        200
        Hours to lunch:
        3.5
        Coding is fun:
        It sure is!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            int dayCount = 200;
            double hoursToLunch = 3.5;
            string statement = "It sure is!";

            // DO NOT TOUCH THESE!
            Console.WriteLine("Days to summer:");
            Console.WriteLine(dayCount);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hoursToLunch);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(statement);

        }
    }
}
