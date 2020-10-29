using System;

namespace exercise_124
{
    /*
        Exercise_124
        Implement a program that causes the NullReferenceException error.
        The error should occur directly after starting the program -- don't wait to read input from the user, for instance.

        HINT! Change an object into null, and try to use it.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            object o = null;
            Type t = o.GetType();
        }
    }
}