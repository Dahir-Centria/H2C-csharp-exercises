using System;
using System.Collections.Generic;

namespace exercise_135
{
    public class UserInterface
    {
        private JokeManager manager;
        public void Start()
        {
            string userInput;

            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("1 - add a joke");
                Console.WriteLine("2 - draw a joke");
                Console.WriteLine("3 - list jokes");
                Console.WriteLine("X - stop");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    userInput = Console.ReadLine();
                    manager.AddJoke(userInput);
                }
                else if (userInput == "2")
                {
                    Console.WriteLine(manager.DrawJoke());
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Printing the jokes.");
                    manager.PrintJokes();
                }
                else if (userInput == "X")
                {
                    break;
                }
                else
                {

                }
            }
        }

        public UserInterface(JokeManager manager)
        {
            this.manager = manager;
        }
    }
}