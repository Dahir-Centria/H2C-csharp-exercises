using System;

namespace exercise_103
{
    /*
        Exercise_103
        The exercise template defines an Agent class, having a first name and last name.
        The Main method tries to print the introduction for mister Bond, but with no luck. This is what is should do:

        public static void Main(string[] args)
        {
          Agent bond = new Agent("James", "Bond");
          Console.WriteLine(bond);

          Agent bourne = new Agent("Jason", "Bourne");
          Console.WriteLine(bourne);
        }
        My name is Bond. James Bond.
        My name is Bourne. Jason Bourne.
        Agent's ToString now returns an empty string. Fix it to introduce international agents in their proper form.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Agent bond = new Agent("James", "Bond");
            Console.WriteLine(bond);

            Agent bourne = new Agent("Jason", "Bourne");
            Console.WriteLine(bourne);
        }
    }
}