using System;
using System.Collections.Generic;

namespace exercise_75
{
    /*
        Exercise_75
        create the method public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit) 
        in the exercise template. The method prints the numbers in the given list whose values are in the range [lowerLimit, upperLimit]. 
        A few examples of using the method are supplied below.

        List<int> numbers = new List<int>();
        numbers.Add(3);
        numbers.Add(2);
        numbers.Add(6);
        numbers.Add(-1);
        numbers.Add(5);
        numnbers.Add(1);

        Console.WriteLine("The numbers in the range [0, 5]");
        PrintNumbersInRange(numbers, 0, 5);

        Console.WriteLine("The numbers in the range [3, 10]");
        PrintNumbersInRange(numbers, 3, 10);
        The numbers in the range [0, 5] 
        3 
        2 
        5 
        1 
        The numbers in the range [3, 10] 
        3 
        6 
        5
    */
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            numbers.Add(5);
            numbers.Add(1);

            Console.WriteLine("The numbers in the range [0, 5]");
            PrintNumbersInRange(numbers, 0, 5);

            Console.WriteLine("The numbers in the range [3, 10]");
            PrintNumbersInRange(numbers, 3, 10);
        }
        public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {
            foreach(int n in numbers)
            {
                if(n >= lowerLimit && n <= upperLimit)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}