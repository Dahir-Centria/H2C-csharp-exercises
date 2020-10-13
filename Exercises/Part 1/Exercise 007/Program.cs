using System;

namespace exercise_07
{
    /*
        Exercise_07
        create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line 3 times. Example output with Hello as input:
        Give input!
        > Hello
        Hello
        Hello
        Hello
    */
    class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask user for string
            //2. print input 3 times

            string userInput;

            Console.WriteLine("Give input!");
            userInput = Console.ReadLine();

            Console.WriteLine(userInput);
            Console.WriteLine(userInput);
            Console.WriteLine(userInput);
        }
    }
}
