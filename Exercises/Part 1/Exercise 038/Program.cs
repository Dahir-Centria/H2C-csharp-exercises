using System;

namespace exercise_38
{
    /*
        Exercise_38
        create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total amount of negative numbers with "Total amount of negative numbers:" and the amount. Do not count the 0 into the amount.
        Give a number:
        > 5
        Give a number:
        > -2
        Give a number:
        > 22
        Give a number:
        > 0
        Total amount of negative numbers: 1
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            string result = "Total amount of negative numbers: ";
            int a;

            for(int count = 0; count != -1;)
            {
                Console.WriteLine("Give a number:");
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);

                if(a == 0)
                {
                    result += count.ToString();
                    break;
                }
                else
                {
                    if(a < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(result);
    }
  }
}
