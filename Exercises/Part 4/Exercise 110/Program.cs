using System;
using System.Collections.Generic;

namespace exercise_110
{
    /*
        Exercise_110
        Implement the class Main described here. Do not modify the class Item.

        Write a program that reads names of items from the user. 
        If the name is empty, the program stops reading. Otherwise, the given name is used to create a new item, 
        which you will then add to the items list.

        Having read all the names, print all the items by using the ToString method of the Item class.
        The implementation of the Item class keeps track of the time of crEation, in addition to the name of the item.

        NOTICE! The list has to be called "items" for the tests to work!

        Example print:

        Name: Hammer
        Name: Radio
        Name: Hot Potato
        Name: 

        Hammer (created at: 9.2.2020 13.48.16)
        Radio (created at: 9.2.2020 13.48.18)
        Hot Potato (created at: 9.2.2020 13.48.21)
    */
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            string userInput;

            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }
                items.Add(new Item(userInput));
            }
            foreach(Item i in items)
            {
                Console.WriteLine(i);
            }
        }
    }
}