using System;

namespace exercise_39
{
    /*
        Exercise_39
        create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total sum of the numbers with "Total sum of numbers:" and the sum. Do not count the 0 into the sum, even though it does not change the result.
        Give a number:
        > 5
        Give a number:
        > -2
        Give a number:
        > 22
        Give a number:
        > 0
        Total sum of numbers: 25
    */
  class Program
  {

    public static void Main(string[] args)
    {
            string userInput;
            string result = "Total sum of numbers: ";
            int a;
            int total = 0;

            for(int i = 0; i == 0;)
            {
                Console.WriteLine("Give a number:");
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);

                if(a == 0)
                {
                    result += total.ToString();
                    break;
                }
                else
                {
                    total += a;
                }
            }
            Console.WriteLine(result);
    }
  }
}
