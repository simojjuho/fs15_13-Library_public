namespace LibraryManagement.Library;

public class Comic : Borrowable
{
    private string _artist;

    public string Artist
    {
        get
        {
            return _artist;
        }
        set
        {
            if (value.Length > 2)
            {
                _artist = value;
            }
            else
            {
                throw new Exception("Artist name must be atleast three letters long");
            }
        }
    }
    
    public Comic(string title, string author, string publicationYear, string artist)
    : base(title, author,  publicationYear, true, false)
    {
        _artist = artist;
    }

    public override string ToString()
    {
        return base.ToString() + $", artist: {_artist}";
    }
}