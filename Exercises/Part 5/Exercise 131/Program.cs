using System;
using System.Collections.Generic;

namespace exercise_131
{
    /*
        Exercise_131
        The program should read items from the user. When all
        the items from the user have been read, the program 
        prints the information of each item.

        For each item, its identifier and name should be read.
        If the identifier or name is empty, the program stops
        asking for input, and prints all the item information.

        Example print:

        Identifier? (empty will stop):
        > B07H8ND8HH 
        Name? (empty will stop):
        > He-Man figure
        Identifier? (empty will stop):
        > B07H8ND8HH 
        Name? (empty will stop):
        > He-Man 
        Identifier? (empty will stop):
        > B07NQFMZYG 
        Name? (empty will stop):
        > He-Man figure 
        Identifier? (empty will stop):
        > B07NQFMZYG 
        Name? (empty will stop):
        > He-Man figure
        Identifier? (empty will stop):
        >

        ==Items== 
        B07H8ND8HH: He-Man figure 
        B07NQFMZYG: He-Man figure
        The printing format of the items should be identifier: name.

        After entering the items, each item is printed at most once.
        Two items should be considered the same if their identifiers 
        are the same (there can be variation in their names in different 
        countries, for instance).

        If the user enters the same item multiple times, the print 
        uses the item that was added first.

        Hint! It is probably smart to add each item to the list at 
        most once -- compare the equality of the objects based on their 
        identifiers.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while(true)
            {
                string id;
                string name;
                Item temp;

                Console.WriteLine("Identifier? (empty will stop):");
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                id = userInput;

                Console.WriteLine("Name? (empty will stop):");
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                name = userInput;

                temp = new Item(id, name);

                bool exist = false;

                foreach(Item item in items)
                {
                    if(item.Equals(temp))
                    {
                        exist = true;
                        break;
                    }
                }
                if(!exist)
                {
                    items.Add(temp);
                }
            }

            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

        }

    }
}