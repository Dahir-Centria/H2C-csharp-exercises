
using System;

namespace exercise_48
{
    /*
        Exercise_48
        Section 1
        Implement a program that asks the user for numbers(the program first prints "Write numbers: ")
        until the user gives the number -1, When the user writes -1, the program prints "Thx! Bye!" and ends.
        Give numbers: 
        > 5 
        > 2 
        > 4 
        > -1 
        Thx! Bye!
        Section 2
        Extend the program so, that it prints the sum of the numbers (not including the -1) the user has written.
        Give numbers: 
        > 5 
        > 2 
        > 4 
        > -1 
        Thx! Bye! 
        Sum: 11
        Section 3
        Extend the program so, that it also prints the number of numbers (not including the -1) the user has written.
        Give numbers: 
        > 5 
        > 2 
        > 4 
        > -1 
        Thx! Bye! 
        Sum: 11
        Numbers: 3
        Section 4
        Extend the program so, that it prints the mean of the numbers (not including the -1) the user has written.
        Give numbers: 
        > 5 
        > 2 
        > 4 
        > -1 
        Thx! Bye! 
        Sum: 11
        Numbers: 3
        Average: 3.666666666666
        Section 5
        Extend the program so that it prints the number of even and odd numbers (excluding the -1).
        Give numbers: 
        > 5 
        > 2 
        > 4 
        > -1 
        Thx! Bye! 
        Sum: 11
        Numbers: 3
        Average: 3.666666666666
        Even: 2
        Odd: 1
    */
  class Program
  {
    public static void Main(string[] args)
    {
            string userInput;

            int a = 0;
            int sum = 0;
            int count = 0;
            int even = 0;
            int odd = 0;
            double average = 0;

            Console.WriteLine("Give numbers:");

            while(a != -1)
            {
                userInput =  Console.ReadLine();
                a = System.Convert.ToInt32(userInput);

                if(a == -1)
                {
                    continue;
                }

                if(a%2 == 1 || a%2 == -1)
                {
                    odd++;
                }
                else
                {
                    even++;
                }

                sum += a;
                count++;
                average = sum/(double)count;
            }

            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Numbers: "+count);
            Console.WriteLine("Average: "+average);
            Console.WriteLine("Even: "+even);
            Console.WriteLine("Odd: "+odd);
    }
  }
}
