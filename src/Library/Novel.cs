namespace LibraryManagement.Library;

public class Novel : Borrowable
{
    private string _genre;

    public string Genre
    {
        get
        {
            return _genre;
        }
        set
        {
            if (value.Length > 3)
            {
                _genre = value;
            }
            else
            {
                throw new Exception("Genre must be at least four letters long");
            }
        }
    }
    public Novel(string title, string author, string publicationYear, string genre)
    : base(title, author, publicationYear, true, false)
    {
        _genre = genre;
    }

    public override string ToString()
    {
        return base.ToString() + $", genre: {_genre}";
    }
}