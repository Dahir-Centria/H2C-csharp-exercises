using System;

namespace exercise_114
{
    /*
        Exercise_114
        As a recap, a simple program of reading the input.

        Write a program that reads strings from the user until the user inputs the string "end".
        At that point, the program should print how many strings have been read. The string "end" 
        should not be included in the number strings read. You can find some examples below of how the program works.

        > I 
        > have
        > a
        > feeling
        > that
        > I
        > have
        > written
        > this
        > wrong
        > before
        > end 
        11
        > end 
        0
    */
    class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            string userInput;
            while(true)
            {
                userInput = Console.ReadLine();

                if(userInput == "end")
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}