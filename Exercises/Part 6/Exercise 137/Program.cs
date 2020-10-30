using System;
using System.Collections.Generic;

namespace exercise_137
{
    /*
        Exercise_137
        Our template has the Person class and some use for it in Main. 
        create a public int HowManyNames() in the Person class, which 
        returns the amount of names a person has, like follows:

        public static void Main(string[] args)
        {
          Person ada = new Person("Ada Lovelace");
          Person jack = new Person("Jack The Ripper");
          Person mike = new Person("Mike The Incredible Magic Mouse");

          Console.WriteLine(ada + " has " ada.HowManyNames() + " names.");
          Console.WriteLine(jack + " has " jack.HowManyNames() + " names.");
          Console.WriteLine(mike + " has " mike.HowManyNames() + " names.");
        }
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE CODE IN HERE
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            Console.WriteLine(ada + " has " + ada.HowManyNames() + " names.");
            Console.WriteLine(jack + " has " + jack.HowManyNames() + " names.");
            Console.WriteLine(mike + " has " + mike.HowManyNames() + " names.");
        }
    }
}