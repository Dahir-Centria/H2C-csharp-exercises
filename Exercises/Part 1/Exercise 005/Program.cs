using System;

namespace exercise_05
{
    /*
        Exercise_05:
        You will find following structure in the exercise:
        using System;
        
        namespace exercise_05
        {
            class Program
            {
                public static void Main(string[] args)
                {
                    string name = "Ada Lovelace";
                    // Write your code here:
                    
                }
            }
        }
        Modify the code, so that it prints Hello Ada Lovelace! Do not modify the variable content!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Ada Lovelace";
            Console.WriteLine("Hello "+name+"!");
        }
    }
}
