using Base;

namespace Library;

public class BookLoan : LoanBase
{
    public BookLoan(string customerId, string itemId) : base(customerId, itemId)
    {
    }
}