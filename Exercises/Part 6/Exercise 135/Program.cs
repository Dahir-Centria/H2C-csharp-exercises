using System;
using System.Collections.Generic;

/*
    Exercise_135
    NOTICE! This exercise does NOT HAVE TESTS. It is up to you to decide,
    when the exercise is ready. I WILL CHECK THEM, SO DON'T CHEat.

    NOTICE 2! This is worth double the points, so 4 in total (2 per section).

    The exercise base contains the following program that has been written "in the main".

    using System;
    using System.Collections.Generic;

    namespace exercise_135
    {
      class Program
      {
        public static void Main(string[] args)
        {
          List<string> jokes = new List<string>();
          Console.WriteLine("What a joke!");

          while (true)
          {
            Console.WriteLine("Commands:");
            Console.WriteLine(" 1 - add a joke");
            Console.WriteLine(" 2 - draw a joke");
            Console.WriteLine(" 3 - list jokes");
            Console.WriteLine(" X - stop");

            string command = Console.ReadLine();

            if (command == "X")
            {
              break;
            }

            if (command == "1")
            {
              Console.WriteLine("Write the joke to be added:");
              string joke = Console.ReadLine();
              jokes.Add(joke);
            }
            else if (command == "2")
            {
              Console.WriteLine("Drawing a joke.");

              if (jokes.Count == 0)
              {
                Console.WriteLine("Jokes are in short supply.");
              }
              else
              {
                Random draw = new Random();
                int index = draw.Next(0, jokes.Count);
                Console.WriteLine(jokes[index]);
              }

            }
            else if (command == "3")
            {
              Console.WriteLine("Printing the jokes.");
              foreach (string joke in jokes)
              {
                Console.WriteLine(joke);
              }
            }
          }
        }
      }
    }
    The application is in practice a storage for jokes. You can add jokes,
    get a randomized joke, and the stored jokes can be printed. In this exercise 
    the program is divided into parts in a guided manner.

    Section 1 - Joke manager
    Create a class called JokeManager and move the functionality to manage jokes in it. The class must have a parameter-free constructor, and the following methods:

    public void AddJoke(string joke) - adds a joke to the manager.
    public string DrawJoke() - chooses one joke at random and returns it. It there are no jokes stored in the joke manager, the method should return the string "Jokes are in short supply.".
    public void PrintJokes() - prints all the jokes stored in the joke manager.
    An example of how to use the class:

    JokeManager manager = new JokeManager();
    manager.AddJoke("What is red and smells of blue paint? - Red paint.");
    manager.AddJoke("What is blue and smells of red paint? - Blue paint.");

    Console.WriteLine("Drawing jokes:");
    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine(manager.DrawJoke());
    }

    Console.WriteLine("");
    Console.WriteLine("Printing jokes:");
    manager.PrintJokes();
    Below is a possible output of the program. Notice that the jokes will probably not be drawn as in this example.

    Drawing jokes: 
    What is blue and smells of red paint? - Blue paint. 
    What is red and smells of blue paint? - Red paint. 
    What is blue and smells of red paint? - Blue paint. 
    What is blue and smells of red paint? - Blue paint. 
    What is blue and smells of red paint? - Blue paint.

    Printing jokes: 
    What is red and smells of blue paint? - Red paint. 
    What is blue and smells of red paint? - Blue paint.
    Section 2 - User Interface
    Create a class called UserInterface and move the UI functionality of
    the program there. The class must have a constructor with one parameter: an 
    instance of the JokeManager class. In addition, the class should have the method
    public void Start() that can be used to start the user interface.

    The user interface should provide the user with the following commands:

    X - ending: exits the method start.
    1 - adding: asks the user for the joke to be added to the joke manager,
    and then adds it.
    2 - drawing: chooses a random joke from the joke manager and prints it.
    If there are no jokes in the manager, thi string "Jokes are in short supply." will be printed.
    3 - printing: prints all the jokes stored in the joke manager.
    An example of how to use the UI:

    JokeManager manager = new JokeManager();
    UserInterface ui = new UserInterface(manager);
    ui.Start();
    Commands: 
     1 - add a joke 
     2 - draw a joke 
     3 - list jokes
      X - stop 
    > 1 
    Write the joke to be added:
    > Did you hear about the claustrophobic astronaut? -- He just needed a little space. 
    Commands:
     1 - add a joke
     2 - draw a joke
     3 - list jokes 
     X - stop 
    > 3 
    Printing the jokes. 
    Did you hear about the claustrophobic astronaut? -- He just needed a little space. 
    Commands:
     1 - add a joke
     2 - draw a joke
     3 - list jokes 
     X - stop 
    > X
*/
namespace exercise_135
{
    class Program
    {
        public static void Main(string[] args)
        {
            JokeManager manager = new JokeManager();
            UserInterface ui = new UserInterface(manager);
            ui.Start();
        }
    }
}