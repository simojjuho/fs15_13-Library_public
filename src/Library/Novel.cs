namespace Library;

public class Novel : Book, IBorrowable
{
    private string _genre { get; } = string.Empty;

    public Novel(string title, string author, string isbn, string publicationYear, string genre)
    : base(title, author, isbn, publicationYear)
    {
        _genre = genre;
    }

    public void Borrow()
    {
        throw new NotImplementedException();
    }

    public void Return()
    {
        throw new NotImplementedException();
    }
}