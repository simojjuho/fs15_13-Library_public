using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public abstract class Book : ItemBase
{
    private string _title { get; } = string.Empty;
    private string _author { get; } = string.Empty;
    private string _publicationYear { get; } = string.Empty;
    
    public void PrintInfo()
    {
        Console.WriteLine($"Book {_title} by {_author} ({_publicationYear}), ISBN: {base.Id}");
    }

    protected Book(string title, string author, string id, string publicationYear) : base(id)
    {
        _title = title;
        _author = author;
        _publicationYear = publicationYear;
    }

    public override string ToString()
    {
        return $"Book title: {_title} by {_author}, published in {_publicationYear}. ISBN: {base.Id}";
    }
}