using System;
using System.Collections.Generic;

namespace exercise_80
{
    /*
        Exercise_80
        The template has a method public static int SumOfNumbersInArray(int[] array).
        Complete the method so, that it computes and returns the sum of the numbers
        in the array it receives as parameter.

        You can try out the computation of the sum with this example:

        int[] numbers = {5, 1, 3, 4, 2};
        int sum = SumOfNumbersInArray(numbers);
        Console.WriteLine(sum);
        15
    */
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            int sum = SumOfNumbersInArray(numbers);
            Console.WriteLine(sum);

        }

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int result = 0;
            foreach(int n in numbers)
            {
                result += n;
            }
            return result;
        }
    }
}