namespace LibraryManagement.Library;
public abstract class Borrowable : Book
{
    protected Borrowable(string title, string author, string publicationYear, bool canBorrow, bool canPrint)
        : base(title, author, publicationYear, canBorrow, canPrint) { }
}