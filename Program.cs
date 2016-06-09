using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bookList = new List<Book>();
            var mobyDick = new Book("Moby Dick", "Herman Mellvile", 1881);
            var harryPotter = new Book("Harry Potter Book 1", "J. K. Rowling", 1997);
            var otherBook = new Book("C# is not better than JS", "Matthew Overall", 2016);

            bookList.Add(mobyDick);
            bookList.Add(harryPotter);
            bookList.Add(otherBook);
            var library = new Library(bookList);

            library.MainScreen();
        }
    }
}
