using System;
using System.Collections.Generic;

namespace exercise_77
{
    /*
        Exercise_77
        create the method public static void RemoveLast(List<string> strings) in the exercise template.
        The method should remove the last value in the list it receives as a parameter.
        If the list is empty, the method does nothing.

        List<string> strings = new List<string>();

        strings.Add("First");
        strings.Add("Second");
        strings.Add("Third");

        // Remember, this is how you print all the items in a list
        strings.ForEach(Console.WriteLine);

        RemoveLast(strings);
        RemoveLast(strings);

        strings.ForEach(Console.WriteLine);
        First
        Second
        Third
        First
    */
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

            strings.ForEach(Console.WriteLine);

            RemoveLast(strings);
            RemoveLast(strings);

            strings.ForEach(Console.WriteLine);
        }
        public static void RemoveLast(List<string> strings)
        {
            if(strings.Count < 1)
            {
                return;
            }
            else
            {
                strings.RemoveAt(strings.Count - 1);
            }
        }
    }
}