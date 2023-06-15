using LibraryManagement.Helpers;
using LibraryManagement.Library;

namespace LibraryManagement.LibraryUI.cs;

public class BookUi
{
    public Book MakeABook()
    {
        Random Random = new();
        var NewTitle = TextInputHelper.GetInput("What is the title of the book: ");
        var NewAuthor = TextInputHelper.GetInput("Who is the author of the book: ");
        var NewPublicationYear = TextInputHelper.GetInput("Which year was the book released: ");
        var NewIsbn = $"{Random.Next(1000)}-{Random.Next(1000)}-{Random.Next(10000)}";

        Console.WriteLine("Which type of a book are you adding:\n1. Novel\n2. Research paper\n3. Comic book\n4. Text book");
        while(true)
        {
            var Type = Console.ReadLine();
            switch(Type)
            {
                case "1":
                    var NewGenre = TextInputHelper.GetInput("What genre does the book belong to :");
                    return new Novel(NewTitle, NewAuthor, NewIsbn, NewPublicationYear, NewGenre);
                case "2":
                    return new ResearchPaper(NewTitle, NewAuthor, NewIsbn, NewPublicationYear);
                case "3":
                    var NewArtist = TextInputHelper.GetInput("Who is the artist: ");
                    return new Comic(NewTitle, NewAuthor, NewIsbn, NewPublicationYear, NewArtist);
                case "4":
                    return new TextBook(NewTitle, NewAuthor, NewIsbn, NewPublicationYear);               
                default:
                    Console.WriteLine("Please choose one of the given options 1-4: ");
                    break;
            }
        }
    }
}