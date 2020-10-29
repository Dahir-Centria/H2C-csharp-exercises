using System;
using System.Collections.Generic;

namespace exercise_111
{
    /*
        Exercise_111
        The program described here should be implemented in the class Main. Do not modify the class PersonalInformation.

        After the user has entered the last set of details (they enter an empty first name), exit the repEat statement.

        Print one empty line here for reading clarity.

        Then print the collected personal information so that each entered object 
        is printed in the following format: first and last names separated by a space
        (you don't print the identification number). An example of the working program is given below:

        First name: 
        > Jean 
        Last name: 
        > Bartik 
        Identification number: 
        > 271224 
        First name: 
        > Betty 
        Last name: 
        > Holberton 
        Identification number: 
        > 070317 
        First name:
        >

        Jean Bartik 
        Betty Holberton
        You can (and should) ask the identification number as a string.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<PersonalInformation> list = new List<PersonalInformation>();

            string firstName;
            string lastName;
            string identificationNumber;

            while(true)
            {
                Console.WriteLine("First name:");
                firstName = Console.ReadLine();

                if(firstName == "")
                {
                    break;
                }

                Console.WriteLine("Last name:");
                lastName = Console.ReadLine();
                Console.WriteLine("Identification number:");
                identificationNumber = Console.ReadLine();

                list.Add(new PersonalInformation(firstName, lastName, identificationNumber));
            }
            foreach(PersonalInformation i in list)
            {
                Console.WriteLine(i.firstName+" "+i.lastName);
            }
        }
    }
}