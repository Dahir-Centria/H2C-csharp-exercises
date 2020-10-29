using System;

namespace exercise_115
{
    /*
        Exercise_115
        Write a program that reads strings from the user until the user inputs the string "end".
        As long as the input is not "end", the program should handle the input as an integer and
        print the cube of the number provided (i.e., number * number * number). Below are some 
        sample outputs

        > 3 
        27 
        > -1 
        -1 
        > 11 
        1331 
        > end
        end
        Remember to convert to integer before calculation!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            int a;
            while(true)
            {
                userInput = Console.ReadLine();
                if(userInput == "end")
                {
                    break;
                }
                else
                {
                    a = Convert.ToInt32(userInput);
                    Console.WriteLine(a * a * a);
                }
            }
            Console.WriteLine("end");
        }
    }
}