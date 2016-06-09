using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> Books { get; set; }
    public List<Book> Cart { get; set; }

    public Library(List<Book> books)
    {
        Books = books;
        Cart = new List<Book>();
    }

    public void MainScreen()
    {
        System.Console.WriteLine("Enter the book number if you wish to check out, 'c' to view your cart or 'q' to quit.");

        var x = 1;

        for (int i = 0; i < Books.Count; i++)
        {
            var currentBook = Books[i];

            System.Console.WriteLine(x++ + ". " + currentBook.Title);
        }

        var input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            Environment.Exit(1);
        }

        if (input.ToLower() == "c")
        {
            ShowCart();
        }
        else
        {
            var index = int.Parse(input)-1;

            Cart.Add(Books[index]);
            System.Console.WriteLine("You just checked out " + Books[index].Title);
            Books[index].CheckedOut = true;
            Books.RemoveAt(index);
            System.Console.WriteLine(string.Join(", ", Cart));
        }
        MainScreen();
    }

    public void ShowCart()
    {
        var y = 1;

        for (int i = 0; i < Cart.Count; i++)
        {
            var currentBook = Cart[i];

            System.Console.WriteLine(y++ + ". " + currentBook.Title);
        }

        System.Console.WriteLine("Enter book number to return book or 'l' to return to the Library");
        var returnBook = Console.ReadLine();

        if (returnBook.ToLower() == "l")
        {
            MainScreen();
            return;
        }

        System.Console.WriteLine(returnBook);
        var index = int.Parse(returnBook) - 1;
        var book = Cart[index];
        Books.Add(book);
        System.Console.WriteLine("You just returned " + book.Title);
        Cart.RemoveAt(index);
        ShowCart();

    }
}