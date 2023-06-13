namespace Library;

public class Library
{
    private List<Book> _bookCollection = new();
    private List<Person> _personCollection = new();
    private List<BookLoan> _activeLoans = new();
    private List<BookLoan> _pastLoans = new(); 

    public Library()
    {}

    public void AddBook(Book book)
    {
        Random random = new();
        string newTitle = getInput("What is the title of the book?");
        string newAuthor = getInput("Who is the author of the book?");
        string newPublicationYear = getInput("Which year was the book released?");
        string newIsbn = $"{random.Next(1000)}-{random.Next(1000)}-{random.Next(10000)}";

        Console.WriteLine("Which type of a book are you adding:\n1. Novel\n2. Research paper\n3. Comic book\n4. Text book");
        string? type = Console.ReadLine();
        
        switch(type)
        {
            case "1":
                string newGenre = getInput("What genre does the book belong to?");
                _bookCollection.Add(new Novel(newTitle, newAuthor, newIsbn, newPublicationYear, newGenre));
                break;
            case "2":
                _bookCollection.Add(new ResearchPaper(newTitle, newAuthor, newIsbn, newPublicationYear));
                break;
            case "3":
                string newArtist = getInput("Who is the artist?");
                _bookCollection.Add(new Comic(newTitle, newAuthor, newIsbn, newPublicationYear, newArtist));
                break;
            case "4":
                _bookCollection.Add(new TextBook(newTitle, newAuthor, newIsbn, newPublicationYear));
                break;
            default:
                Console.WriteLine("Please choose one of the given options 1-4.");
                break;
        }

        if(_bookCollection.Exists((Book book) => book.Isbn == newIsbn))
        {
            Console.WriteLine("Book created");
        }
        else
        {
            throw new Exception("Adding a new book failed");
        }
    }

    private string getInput(string instruction)
    {
        while(true)
        {
            Console.WriteLine(instruction);
            string? input = Console.ReadLine();
            if(input != null)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please give a proper input.");
            }
        }
    }

    public void BorrowBook(string isbn, string customerId)
    {
        BookLoan? loan = _activeLoans.Find((BookLoan loan) => loan.Isbn == isbn);
        if(loan != null)
        {
            Console.WriteLine("Book has been already borrowed.");
        }
        else
        {
            _activeLoans.Add(new BookLoan(customerId, isbn));
        }
    }

    public void ReturnBook(string isbn)
    {
        BookLoan? loan = _activeLoans.Find((BookLoan loan) => loan.Isbn == isbn);
        if(loan != null)
        {
            Console.WriteLine("Book has been already borrowed.");
        }
        else
        {
            _activeLoans.Where((BookLoan loan) => loan.Isbn != isbn);
            _pastLoans.Add(loan);
        }
    }

    public void AddPerson(Person person)
    {
        
    }

    public void RemovePerson(string id)
    {
        
    }

    public void EditPerson(string id)
    {
        
    }
}