using System;
using System.Collections;
using System.Collections.Generic;

namespace exercise_85
{
    /*
        Exercise_85
        write a program that recognizes the following users:

        username	password
        alex	sunshine
        emma	haskell
        The program either shows a login message or informs of incorrect username or password.

        Enter username: 
        >alex 
        Enter password: 
        > sunshine 
        You have successfully logged in!
        Enter username: 
        > emma 
        Enter password: 
        > haskell 
        You have successfully logged in!
        Enter username: 
        > alex 
        Enter password: 
        > haskell 
        Incorrect username or password!

        NOTICE! In read life login should not be implemented like this! This is just an exercise.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string result;
            string userInput;
            string a;
            string b;
            
            Hashtable users = new Hashtable();//am i allowed to use this? if not the next method i would have used is to create something similar out of a string array.
            
            users.Add("alex", "sunshine");
            users.Add("emma", "haskell");

            Console.WriteLine("Enter username:");
            userInput = Console.ReadLine();
            a = userInput;

            Console.WriteLine("Enter password:");
            userInput = Console.ReadLine();
            b = userInput;

            if(users[a] != null && users[a].ToString() == b)
            {
                result = "You have successfully logged in!";
            }
            else
            {
                result = "Incorrect username or password!";
            }

            Console.WriteLine(result);
        }
    }
}