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
            string name;
            string profession;

            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            profession = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a "+profession+" called "+name+
                "\nOn her way to work, "+name+" often pondered what being "+profession+
                " meant to them.\nWhen you work as a "+profession+" you meet interesting people.\n"
                +name+" enjoys their work as "+profession+", The end.");
        }
    }
}
