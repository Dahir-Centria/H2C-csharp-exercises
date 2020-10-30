using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace exercise_135
{
    public class JokeManager
    {
        List<string> jokes;
        Random random;

        public void AddJoke(string joke)
        {
            jokes.Add(joke);
            //adds a joke to the manager.
        }
        public string DrawJoke()
        {
            //chooses one joke at random and returns it. It there are no jokes stored in the joke manager, the method should return the string "Jokes are in short supply.".
            if (jokes.Count < 1)
            {
                return "Jokes are in short supply.";
            }
            int randomNumber = random.Next(0, jokes.Count);
            return jokes[randomNumber];
        }
        public void PrintJokes()
        {
            if (jokes.Count < 1)
            {
                Console.WriteLine("Jokes are in short supply.");
                return;
            }
            foreach (string joke in jokes)
            {
                Console.WriteLine(joke);
            }
            //prints all the jokes stored in the joke manager.
        }
        public JokeManager()
        {
            jokes = new List<string>();
            random = new Random();
        }
    }
}