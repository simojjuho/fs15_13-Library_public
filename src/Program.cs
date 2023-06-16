using LibraryManagement.Library;

namespace LibraryManagement;

class Program
{
    static void Main()
    {
        // I don't know, what is the reason, that JetBrains Rider does not recognize Library class without Library.Library on the next line.
        var library = new Library.Library();

        var book1 = new Novel("There and back again, a Hobbit's story", "John Ronald Reuel Tolkien", "1954", "Fantasy" );
        var book2 = new ResearchPaper("How Did The Hobbits Manage To Be So Brave - A Comprehensive Study",
            "Alister McGrath", "1999");
        var book3 = new TextBook("The Geography Of The Middle Earth", "Maija Järviniemi", "2008");
        var book4 = new Comic("The Lord Of The Rings - The Comic book", "Tolkien", "2025", "Matilda Löytty");
        var book5 = new Novel("The Lord Of The Rings", "John Ronald Reuel Tolkien", "1975", "Fantasy" );
        var book6 = new ResearchPaper("Behind the Rise Of Evil - Why Are We So Prone To Go To War?", "John Lennox", "2005");

        var customer1 = new Customer("Carrie Customer");
        var customer2 = new Customer("Barry Bookworm");
        var customer3 = new Customer("Reese Reader");

        var librarian = new Librarian("Larry Librarian");

        librarian.AddBook(book1, library);
        librarian.AddBook(book2, library);
        librarian.AddBook(book3, library);
        librarian.AddBook(book4, library);
        librarian.AddBook(book5, library);
        librarian.AddBook(book6, library);
        
        library.AddMember(customer1);
        library.AddMember(customer2);
        library.AddMember(customer3);
        library.AddMember(librarian);
        
        customer1.BorrowBook(book1, library);
        customer2.BorrowBook(book1, library);
        
        library.ListLoans();
        
        Console.WriteLine(library);
        
        librarian.RemoveBook(book2, library);
        customer1.ReturnBook(book1, library);
        library.ListLoans();
        
    }
}