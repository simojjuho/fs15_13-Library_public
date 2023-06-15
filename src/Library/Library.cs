using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public class Library : LoanServiceBase<Book, BookLoan, LibraryMember>
{
    public Library()
    {}
}