using System;

namespace exercise_06
{
    /*
        Exercise_06
        create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line. Example output with Hello as input (input marked with > for clarification):
        Give input!
        > Hello
        Hello
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("Give input!");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);
        }
    }
}
