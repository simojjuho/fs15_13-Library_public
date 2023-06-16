using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public class Customer : LibraryMember
{
    public Customer(string name) : base(name)
    {}

    public void BorrowBook(Book book, Library library)
    {
        Console.WriteLine("Borrowing a book...");
        var Loan = library.BorrowItem(book.Id, Id);
        Console.WriteLine(Loan ? $"Success borrowing {book.Title} by {book.Author}!" : "Failed to borrow, book already borrowed!");
    }

    public void ReturnBook(Book book, Library library)
    {
        Console.WriteLine($"Returning a book {book}");
        var Loan = library.ReturnItem(book.Id);
        Console.WriteLine(Loan ? "Success!" : "Failed!");
    }
}