using System;
using System.Collections.Generic;

namespace exercise_130
{
    /*
        Exercise_130
        There is a program in the exercise base that asks for books from the user and adds them to a list.

        Modify the program so that books that are already on the list are not added to it again.
        Two books should be considered the same if they have the same name and publication year.

        Example print:

        Name (empty will stop): 
        > Bossypants 
        Publication year: 
        >2013 
        Name (empty will stop):
        > Seriously...I'm Kidding
        Publication year:
        > 2012 
        Name (empty will stop):
        > Seriously...I'm Kidding 
        Publication year:
        > 2012 
        The book is already on the list. Let's not add the same book again. 
        Name (empty will stop):
        >

        Thank you! Books added: 2
    */
    class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Name (empty will stop):");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.WriteLine("Publication year:");
                int publicationYear = Convert.ToInt32(Console.ReadLine());
                Book book = new Book(name, publicationYear);

                // BEGIN SOLUTION
                // Add unique books to the list.
                // Remember to print
                // "The book is already on the list. Let's not add the same book again."
                // If the list Contains the book
                bool exist = false;

                foreach(Book b in books)
                {
                    if(b.Equals(book))
                    {
                        exist = true;
                        break;
                    }
                }
                if(exist)
                {
                    Console.WriteLine("The book is already on the list. Let's not add the same book again.");
                }
                else
                {
                    books.Add(book);
                }


                // END SOLUTION
            }

            // Don't alter the line below!
            Console.WriteLine("Thank you! Books added: " + books.Count);
        }
    }
}