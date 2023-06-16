using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public abstract class Book : ItemBase
{
    private string _title;
    private string _author;
    private string _publicationYear;
    private bool _canPrint;
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            if (value.Length > 0)
            {
                _title = value;
            }
        }
    }
    
    public string PublicationYear
    {
        get
        {
            return _publicationYear;
        }
        set
        {
            if (value.Length == 4)
            {
                _publicationYear = value;
            }
            else
            {
                throw new Exception("Publication year must be fours numbers.");
            }
        }
    }
    
    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            if (value.Length > 0)
            {
                _author = value;
            }
        }
    }

    public bool CanPrint
    {
        get
        {
            return _canPrint;
        }
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Book {_title} by {_author} ({_publicationYear}), ISBN: {base.Id}");
    }

    protected Book(string title, string author, string publicationYear, bool canBorrow, bool canPrint) : base(canBorrow)
    {
        _title = title;
        _author = author;
        _publicationYear = publicationYear;
        _canPrint = canPrint;
    }

    public override string ToString()
    {
        return $"Book title: {Title} by {Author}, published in {PublicationYear}. ISBN: {Id}";
    }
}