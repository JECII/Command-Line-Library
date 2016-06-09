using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool CheckedOut { get; set; }
    public Book(string title, string author, int pubYear) {

        Title = title;
        Author = author;
        PublicationYear = pubYear;

    }
}