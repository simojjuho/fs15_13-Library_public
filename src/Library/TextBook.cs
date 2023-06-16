using LibraryManagement.Interfaces;

namespace LibraryManagement.Library;

public class TextBook : Borrowable, IPrintable
{
    public TextBook(string title, string author, string publicationYear)
    : base(title, author, publicationYear, true, true)
    {}

    public void PrintPages(int startPage, int endPage)
    {
        if(endPage - startPage < 0)
        {
            Console.WriteLine("Starting page must come before the end page");
        }
        else if(endPage - startPage > 50)
        {
            Console.WriteLine("You are only allowed to print maximum of 50 pages");
        }
        else
        {
            Console.WriteLine("Lorem imsum and so on and so forth, pages coming!");
        }
    }
}