using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public class BookLoan : LoanBase
{
    public BookLoan() { }

    public override string ToString()
    {
        return $"Bookloan id: {base.Id}, book id: {base.ItemId}, customer {base.CustomerId}. Is returned: {base.IsActive}";
    }
}