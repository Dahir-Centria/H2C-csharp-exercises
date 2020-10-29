using System;

namespace exercise_101
{
    /*
    Exercise_101
    Create a class called Dalmatian. The dalmatian has instance variables string name and int spots.
    Both are set in the public Dalmatian(string name, int spots) constructor.
    Also, give the variables ability for get and set: Make the variables public rather than private, and add { get; set; } on the declaring lines!

    Dalmatian spotty = new Dalmatian("Spot", 306);
    Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
    Spot is a very good dog. He has 306 darker spots in his fur
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Dalmatian spotty = new Dalmatian("Spot", 306);
            Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
        }
    }
}