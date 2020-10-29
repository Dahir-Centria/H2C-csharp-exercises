using System;

namespace exercise_129
{
    /*
        Exercise_129
        In the exercise base there is a class called Song that can be used to create new 
        objects that represent songs. Add to that class the Equals
        method so that the similarity of songs can be examined.

        You can try your code with this:

        public static void Main(string[] args)
        {
          // Try your code here, if you want
          Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
          Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

          if (jackSparrow.Equals(anotherSparrow))
          {
            Console.WriteLine("Songs are equal.");
          }

          if (jackSparrow.Equals("Another object"))
          {
            Console.WriteLine("Strange things are afoot.");
          }
        }
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

            if (jackSparrow.Equals(anotherSparrow))
            {
                Console.WriteLine("Songs are equal.");
            }

            if (jackSparrow.Equals("Another object"))
            {
                Console.WriteLine("Strange things are afoot.");
            }
        }

    }
}