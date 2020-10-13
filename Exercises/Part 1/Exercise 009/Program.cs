using System;

namespace exercise_09
{
    /*
        Exercise_09
        create a program, that simulates a small conversation. The program will tell three lines, and expects two user inputs. Example output:
        Hello, how are you?
        > Fine, thanks.
        That's interesting, tell me more
        > I learn coding
        Thank you for sharing!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, how are you?");
            Console.ReadLine();
            Console.WriteLine("That's interesting, tell me more");
            Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");
        }
    }
}
