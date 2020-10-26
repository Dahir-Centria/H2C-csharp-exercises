using System;

namespace exercise_47
{
    /*
        Exercise_47
        Section 1
        Write a program, which prints integers from 1 to a number given by the user.
        Where to? 
        >3 
        1 
        2 
        3
        Where to? 
        >5 
        1 
        2 
        3 
        4 
        5
        Hint: the number read from the user is now the upper limit of the condition.
        Remember that a <= b means a is smaller or equal to b.

        Section 2
        Ask the user for the starting point as well.
        Where to? 
        >8 
        Where from? 
        >5
        5 
        6 
        7 
        8
        If the upper limit is larger than the starting point, nothing is printed:

        Where to? 
        > 12 
        Where from? 
        > 16
        Hint: Remember that the lower and the upper limits can be negative!
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;
            int a;
            int b;
            int counter;

            Console.WriteLine("Where to?");
            userInput =  Console.ReadLine();
            b = System.Convert.ToInt32(userInput);

            Console.WriteLine("Where from?");
            userInput =  Console.ReadLine();
            a = System.Convert.ToInt32(userInput);

            counter = (a-b);

            if(counter < 0)
            {
                while(counter != 0)
                {
                  Console.WriteLine(b+counter);
                  if(counter < 0)
                  {
                      counter++;
                  }
                  else
                  {
                      counter--;
                  }
                }
                Console.WriteLine(b+counter);
            }
    }
  }
}
