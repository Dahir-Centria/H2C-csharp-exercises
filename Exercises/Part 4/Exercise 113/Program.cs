using System;
using System.Collections.Generic;

namespace exercise_113
{
    /*
        Exercise_113
        This exercise is worth 2.

        Write a program that first reads book information from the user.
        The details to be asked for each book include the title, the number of pages, and the publication year.
        Entering an empty string as the name of the book ends the reading process.

        After this the user is asked for what is to be printed. If the user inputs "everything", 
        all the details are printed: the book titles, the numbers of pages, and the publication years.
        However, if the user enters the string "title", only the book titles are printed.
        If something else than "everything" or "title" is given, the program should not print anything.

        Implement the class Book.
        Implement the functionality in the Main method.
        Example of how the program in Main should work:

        Name: To Kill a Mockingbird 
        Pages: 281 
        Publication year: 1960 
        Name: A Brief History of Time 
        Pages: 256 
        Publication year: 1988 
        Name: Beautiful Code 
        Pages: 593 
        Publication year: 2007 
        Name: The Name of the Wind 
        Pages: 662 
        Publication year: 2007 
        Name:

        What information will be printed? everything 
        To Kill a Mockingbird, 281 pages, 1960 
        A Brief History of Time, 256 pages, 1988 
        Beautiful Code, 593 pages, 2007 
        The Name of the Wind, 662 pages, 2007
        Name: To Kill a Mockingbird 
        Pages: 281 
        Publication year: 1960 
        Name: A Brief History of Time 
        Pages: 256 
        Publication year: 1988 
        Name: Beautiful Code 
        Pages: 593 
        Publication year: 2007 
        Name: The Name of the Wind 
        Pages: 662 
        Publication year: 2007 
        Name:

        What information will be printed? title 
        To Kill a Mockingbird 
        A Brief History of Time 
        Beautiful Code 
        The Name of the Wind
    */
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;
            List<Book> books = new List<Book>();

            while (true)
            {
                string name;
                string pages;
                string published;

                Console.Write("Name: ");
                userInput = Console.ReadLine();
                name = userInput;

                if (userInput == "")
                {
                    break;
                }

                Console.Write("Pages: ");
                userInput = Console.ReadLine();
                pages = userInput;

                Console.Write("Publication year: ");
                userInput = Console.ReadLine();
                published = userInput;

                books.Add(new Book(name, pages, published));
            }
            Console.Write("What information will be printed? ");
            userInput = Console.ReadLine();

            if (userInput == "everything")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }

            else if (userInput == "title")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.title);
                }
            }
            else
            {

            }
        }
    }
}