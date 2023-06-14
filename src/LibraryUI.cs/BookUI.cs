using Utilities;
using Library;

namespace LibraryUI;

public class BookUI
{
    public Book MakeABook()
    {
        Random random = new();
        string newTitle = TextInputHelper.GetInput("What is the title of the book: ");
        string newAuthor = TextInputHelper.GetInput("Who is the author of the book: ");
        string newPublicationYear = TextInputHelper.GetInput("Which year was the book released: ");
        string newIsbn = $"{random.Next(1000)}-{random.Next(1000)}-{random.Next(10000)}";

        Console.WriteLine("Which type of a book are you adding:\n1. Novel\n2. Research paper\n3. Comic book\n4. Text book");
        while(true)
        {
            string? type = Console.ReadLine();
            switch(type)
            {
                case "1":
                    string newGenre = TextInputHelper.GetInput("What genre does the book belong to :");
                    return new Novel(newTitle, newAuthor, newIsbn, newPublicationYear, newGenre);
                case "2":
                    return new ResearchPaper(newTitle, newAuthor, newIsbn, newPublicationYear);
                case "3":
                    string newArtist = TextInputHelper.GetInput("Who is the artist: ");
                    return new Comic(newTitle, newAuthor, newIsbn, newPublicationYear, newArtist);
                case "4":
                    return new TextBook(newTitle, newAuthor, newIsbn, newPublicationYear);               
                default:
                    Console.WriteLine("Please choose one of the given options 1-4: ");
                    break;
            }
        }
    }
}