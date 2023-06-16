using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public class Librarian : LibraryMember
{
    public Librarian(string name) : base(name)
    {
    }

    public void AddBook(Book book, Library library)
    {
        var IsSuccess = library.AddItem(book);
        Console.WriteLine(IsSuccess ? $"Success adding {book.Title} by {book.Author}" : "Adding failed");
    }

    public void UpdateBook(Book updateBook, Book oldBook, Library library)
    {
        var IsSuccess = library.UpdateItem(updateBook, oldBook.Id);
        Console.WriteLine(IsSuccess ? "Success" : "Adding failed");
    }

    public void RemoveBook(Book book, Library library)
    {
        var IsSuccess = library.RemoveItem(book.Id);
        Console.WriteLine(IsSuccess ? $"Succesfully removed book { book }" : "Remove failed");
    }
}