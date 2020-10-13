using System;

namespace exercise_10
{
    /*
        Exercise_10
        create a program, that asks the user for a name and a profession. Then make the program to write a little story with this information. Here is an example story with inputs Ada and Data Scientist.
        NOTICE! Every Ada and Data Scientist in the story are the inputs by the user. Remember to save the Console.ReadLines into variables and use them as parts of the story!

        I will tell a story, but I need some information.
        Give a name for main character:
        > Ada
        Give the character a profession:
        > Data Scientist
        Here is the story:
        Once upon a time there was a Data Scientist called Ada
        On her way to work, Ada often pondered what being Data Scientist meant to them.
        When you work as a Data Scientist you meet interesting people.
        Ada enjoys their work as Data Scientist, The end.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            string userInput1;
            string userInput2;

            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            userInput1 = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            userInput2 = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a "+userInput2+" called "+userInput1+
                "\nOn her way to work, "+userInput1+" often pondered what being "+userInput2+
                " meant to them.\nWhen you work as a "+userInput2+" you meet interesting people.\n"
                +userInput1+" enjoys their work as "+userInput2+", The end.");
        }
    }
}
