namespace Library;

public class Comic : Book, IBorrowable
{
    private string _artist { get; } = string.Empty;
    public Comic(string title, string author, string isbn, string publicationYear, string artist)
    : base(title, author, isbn, publicationYear)
    {
        _artist = _artist;
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