namespace Library;

public class BookLoan
{
    private string _customerId = string.Empty;
    private string _isbn = string.Empty;
    private bool _isActive = false;

    public string Isbn
    {
        get
        {
            return _isbn;
        }
    }
    
    public bool isActive
    {
        get
        {
            return _isActive;
        }
        set
        {
            _isActive = value;
        }
    }

    public BookLoan(string customerId, string isbn)
    {
        _customerId = customerId;
        _isbn = isbn;
    }
}