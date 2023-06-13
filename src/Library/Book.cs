namespace Library;

public abstract class Book
{
    private string _title { get; } = string.Empty;
    private string _author { get; } = string.Empty;
    private string _isbn = string.Empty;
    private string _publicationYear { get; } = string.Empty;

    public string Isbn
    {
        get
        {
            return _isbn;
        }
    }

    public Book(string title, string author, string isbn, string publicationYear)
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _publicationYear = publicationYear;        
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Book {_title} by {_author} ({_publicationYear}), ISBN: {_isbn}");
    }
}