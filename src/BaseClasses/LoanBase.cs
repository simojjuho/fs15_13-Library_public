namespace Base;

public abstract class LoanBase
{
    private string _id;
    private string _customerId = string.Empty;
    private string _itemId = string.Empty;
    private bool _isActive = false;

    public string Id
    {
        get
        {
            return _id;
        }
    }

    public string CustomerId
    {
        get
        {
            return _customerId;
        }
        set
        {
            if(value.Length > 0)
            {
                _customerId = value;
            }
            else
            {
                throw new Exception("Customer id not long enough.");
            }
        }
    }

    public string ItemId
    {
        get
        {
            return _itemId;
        }
        set
        {
            if(value.Length > 0)
            {
                _itemId = value;
            }
            else
            {
                throw new Exception("Item id not long enough.");
            }
        }
    }

    public bool IsActive
    {
        get
        {
            return _isActive;
        }
        set
        {
            if(value != _isActive)
            {
                _isActive = value;
            }
            else
            {
                throw new Exception("Could not change loan status.");
            }
        }
    }

    public LoanBase(string customerId, string itemId)
    {
        _customerId = customerId;
        _itemId = itemId;
        _id = new Random().Next().ToString();
        _isActive = true;
    }
}