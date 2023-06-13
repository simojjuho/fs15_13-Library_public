namespace Library;

public class ResearchPaper : Book, IPrintable
{
    public ResearchPaper(string title, string author, string isbn, string publicationYear) : base(title, author, isbn, publicationYear)
    {}

    public void PrintPages(int startPage, int endPage)
    {
        if(endPage - startPage < 0)
        {
            Console.WriteLine("Starting page must come before the end page");
        }
        else if(endPage - startPage > 30)
        {
            Console.WriteLine("You are only allowed to print maximum of 30 pages");
        }
        else
        {
            Console.WriteLine("Lorem imsum and so on and so forth, pages coming!");
        }
    }
}