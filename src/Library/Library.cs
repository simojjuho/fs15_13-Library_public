using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public class Library : LoanServiceBase<Book, BookLoan, LibraryMember>
{
    public Library()
    {}
    
    public void ListLoans()
    {
        Console.WriteLine("Books borrowed from the library:");
        foreach (var loan in ActiveLoans)
        {
            Console.WriteLine(loan);
        }
    }
}