namespace LibraryManagement.BaseClasses;

public abstract class LoanServiceBase<T, K, P> where T : ItemBase where K : LoanBase, new() where P : PersonBase
{
    private List<T> _items = new();
    private List<K> _activeLoans = new();
    private List<K> _pastLoans = new();
    private List<P> _members = new();

    public List<K> ActiveLoans => _activeLoans;

    protected LoanServiceBase() {}

    public bool AddItem(T item){
        _items.Add(item);
        if(_items.Contains(item))
        {
            return true;
        }
        else
        {
            throw new Exception("Something went wrong, please try again.");
        }
    }

    public bool RemoveItem(string id)
    {
        _items = _items.Where(item => item.Id == id).ToList();
        return !_items.Exists(item => item.Id == id);
    }

    public bool BorrowItem(string id, string customerId){
        var Loan = _activeLoans.Find((K loan) => loan.ItemId == id);
        var Item = GetItemById((id));
        if(Loan != null || !Item.CanBorrow)
        {
            return false;
        }
        else
        {
            // JetBrains Rider's recommendation to use object initializer
            var NewLoan = new K
            {
                ItemId = id,
                CustomerId = customerId
            };
            _activeLoans.Add(NewLoan);
            return true;
        }
    }

    public bool ReturnItem(string id){
        var Loan = _activeLoans.Find((K loan) => loan.ItemId == id);
        if(Loan != null)
        {
            return false;
        }
        else
        {
            _activeLoans = _activeLoans.Where((K loan) => loan.ItemId != id).ToList();
            _pastLoans.Add(Loan);
            return true;
        }
    }

    public T GetItemById(string id)
    {
        var Item = _items.Find(p => p.Id == id);
        if(Item is not null)
        {
            return Item;
        }
        else
        {
            throw new Exception("Please check the id, could not find an item.");
        }
    }
    
    public bool UpdateItem(T update, string id){
        var Item = GetItemById(id);

        var UpdateProps = update.GetType().GetProperties();
        var OldProps = Item.GetType().GetProperties();

        foreach(var Property in OldProps)
        {
            if(update.GetType().GetProperty(Property.Name) is not null)
            {
                if(Property.CanWrite)
                {
                    Property.SetValue(Item, update.GetType().GetProperty(Property.Name)!.GetValue(update));
                }
            }
        }
        return true;
    }

    public bool AddMember(P person){
        if(_members.Contains(person))
        {
            throw new Exception("Member already added.");
        }
        _members.Add(person);
        if(_members.Contains(person))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool RemoveMember(string id){
        if(_members.Exists(person => person.Id == id))
        {
            _members = _members.Where(person => person.Id == id).ToList();
            return true;
        }
        return false;
    }

    public P GetMemberById(string id)
    {
        var Person = _members.Find(p => p.Id == id);
        if(Person is not null)
        {
            return Person;
        }
        else
        {
            throw new Exception("Please check the id, could not find anyone.");
        }
    }

    public override string ToString()
    {
        var AmountOfLibrarians = _members.Count(m => m.GetType().Name == "Librarian");
        return $"Library: books {_items.Count}, library members: {_members.Count} of which  personnel: {AmountOfLibrarians}";
    }
}