using System;
using System.Collections.Generic;

namespace exercise_112
{
    /*
        Exercise_112
        In the exercise template there is a ready-made class TelevisionProgram, representing a television program.
        The class has object variables name and duration, a constructor, and a few methods.

        Implement a program that begins by reading television programs from the user.
        When the user inputs an empty string as the name of the program, the program stops reading programs.

        After this the user is queried for a maximum duration. Once the maximum is given, the program proceeds
        to list all the programs whose duration is smaller or equal to the specified maximum duration.

        Name: Rick and Morty 
        Duration: 25 
        Name: Two and a Half Men 
        Duration: 30 
        Name: Love it or list it 
        Duration: 60 
        Name: House 
        Duration: 60
        Name:

        Program's maximum duration? 30 
        Rick and Morty, 25 minutes 
        Two and a Half Men, 30 minutes
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> list = new List<TelevisionProgram>();

            string userInput;
            int limit;

            while (true)
            {
                string name;
                int duration;

                Console.Write("Name: ");

                userInput = Console.ReadLine();
                name = userInput;

                if (name == "")
                {
                    Console.WriteLine("");
                    break;
                }

                Console.Write("Duration: ");

                userInput = Console.ReadLine();
                duration = Convert.ToInt32(userInput);

                list.Add(new TelevisionProgram(name, duration));
            }
            Console.Write("Program's maximum duration? ");
            userInput = Console.ReadLine();
            limit = Convert.ToInt32(userInput);

            foreach (TelevisionProgram i in list)
            {
                if(i.duration <= limit)
                {
                    Console.WriteLine(i.name + ", " + i.duration + " minutes");
                }
            }
        }
    }
}