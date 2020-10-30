using System;
using System.Collections.Generic;

namespace exercise_136
{
    /*
        Exercise_136
        Our template has the Person class and some use for it in Main.
        create a public static void HowManyNames(Person person) for the 
        Main Program, which prints the name and the amount of names as follows:

        public static void Main(string[] args)
        {
          Person ada = new Person("Ada Lovelace");
          Person jack = new Person("Jack The Ripper");
          Person mike = new Person("Mike The Incredible Magic Mouse");

          HowManyNames(ada);
          HowManyNames(jack);
          HowManyNames(mike);
        }
        Ada Lovelace has 2 names.
        Jack The Ripper has 3 names.
        Mike The Incredible Magic Mouse has 5 names.
        NOTICE! The Console.WriteLine is called from inside the method this time!
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            HowManyNames(ada);
            HowManyNames(jack);
            HowManyNames(mike);
        }
        public static void HowManyNames(Person person)
        {
            string[] names = person.ToString().Split(' ');
            Console.WriteLine(person+" has "+names.Length+" names.");
        }
    }
}