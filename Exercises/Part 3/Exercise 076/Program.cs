using System;
using System.Collections.Generic;

namespace exercise_76
{
    /*
        Exercise_76
        create the method public static int Sum(List<int> numbers) in the exercise template.
        The method is to return the sum of the numbers in the parameter list.

        List<int> numbers = new List<int>();
        numbers.Add(3);
        numbers.Add(2);
        numbers.Add(6);
        numbers.Add(-1);
        Console.WriteLine(Sum(numbers));

        numbers.Add(5);
        numbers.Add(1);
        Console.WriteLine(Sum(numbers));
        10
        16
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
            Console.WriteLine(Sum(numbers));

            numbers.Add(5);
            numbers.Add(1);
            Console.WriteLine(Sum(numbers));
        }
        public static int Sum(List<int> numbers)
        {
            int sum = 0;
            if(numbers.Count == 0)
            {
                return sum;
            }
            else
            {
                foreach(int n in numbers)
                {
                    sum += n;
                }
            }
            return sum;
        }
    }
}