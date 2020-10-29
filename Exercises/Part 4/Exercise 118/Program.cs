using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exercise_118
{
    /*
        Exercise_118
        The exercise template comes ready with functionality for the guest list
        application. It checks whether names entered by the user are on the guest list.

        However, the program is missing the functionality needed for reading the
        guest list. Modify the program so that the names on the guest list are read from the file.

        Name of the file: guestlist.txt

        Enter names, an empty line quits. 
        > Chuck Norris 
        The name is not on the list. 
        > Jack Baluer 
        The name is not on the list. 
        > Jack Bauer 
        The name is on the list. 
        > Jack Bower 
        The name is on the list.
        >
        Thank you!
        NOTICE! The exercise template comes with two files, names.txt and 
        other-names.txt, which have the following contents. Do not change the contents of the files!

        NOTICE2! The exercise expects you to have a string names where you store the file!

        names.txt:

        ada
        arto
        leena
        test
        heikki

        other-names.txt:

        leo
        jarmo
        alicia
        mike
        potato
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the file name and print the content of the file
            Console.WriteLine("Name of the file:");
            string file = Console.ReadLine();

            // DO NOT TOUCH THE CODE ABOVE!
            // implement reading the file here;
            DirectoryInfo info = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
            FileInfo[] fInfo = info.GetFiles(file);
            Console.WriteLine(fInfo[0].FullName);
            List<string> names = File.ReadAllLines(fInfo[0].FullName).ToList<string>();

            // DO NOT TOUCH THE CODE BELOW!
            Console.WriteLine("");

            Console.WriteLine("Enter names, an empty line quits.");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                if (names.Contains(name))
                {
                    Console.WriteLine("The name is on the list.");
                }
                else
                {
                    Console.WriteLine("The name is not on the list.");
                }
            }

            Console.WriteLine("Thank you!");

        }
    }
}