using System;

namespace exercise_130
{
    public class Book
    {
        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }


        // BEGIN SOLUTION
        public override bool Equals(object compared)
        {
            if (compared.GetType() == this.GetType())
            {
                Book book = (Book)compared;
                if (name == book.name && publicationYear == book.publicationYear)
                {
                    return true;
                }
            }
            return false;
        }
        // END SOLUTION
    }
}