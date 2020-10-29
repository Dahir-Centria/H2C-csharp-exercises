using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Book
    {
        public string title { get; }
        public string pages { get; }
        public string published { get; }
        public override string ToString()
        {
            string result = title + ", " + pages + " pages, " + published;
            return result;
        }
        public Book(string title, string pages, string published)
        {
            this.title = title;
            this.pages = pages;
            this.published = published;
        }
    }
}