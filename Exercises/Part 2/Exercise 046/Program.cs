using System;

namespace exercise_46
{
    /*
        Exercise_46
        Write a program, which reads an integer from the user.
        Then the program prints numbers from that number to 100.
        You can assume that the user always gives a number less than 100.
        Below are some examples of the wanted functionality.
        > 99
        99
        100
        > -4
        -4
        -3
        -2
        -1
        0
        1
        ... (lots of numbers in between) ...
        98
        99
        100
        NOTICE!
        From now on, the exercises might be in multiple sections in the instructions, to make it easier to comprehend.
        In the end, you should still have only one program per exercise to return.

        Each section is counted separately, when calculating the total amount of exercises done.
        For example, the next exercise with 2 sections, counts as 2 exercises in the total sum you have done.

        Hint: The last section always shows what the program should do in total.
        When all the tests pass, you have done all the sections.
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;

            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            for(int result = a; result <= 100; result++)
            {
                Console.WriteLine(result);
            }
    }
  }
}
