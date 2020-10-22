using System;

namespace exercise_40
{
    /*
        Exercise_40
        create a program which asks the user for integers. Exit with 0. In the end, output both the amount and the sum. Do not count 0 to either.
        Give a number:
        > 5
        Give a number:
        > -2
        Give a number:
        > 22
        Give a number:
        > 0
        Total sum of numbers: 25
        Total amount of numbers: 3
        Hint: You will need two variables to store the data, one for the sum, one for the amount.
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            string result = "Total sum of numbers: ";
            string result2 = "Total amount of numbers: ";
            int a;
            int total = 0;

            for(int count = 0; count != -1;)
            {
                Console.WriteLine("Give a number:");
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);

                if(a == 0)
                {
                    result += total.ToString();
                    result2 += count.ToString();
                    break;
                }
                else
                {
                    count++;
                    total += a;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(result2);
    }
  }
}
