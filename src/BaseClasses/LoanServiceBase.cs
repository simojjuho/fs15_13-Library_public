namespace Base;

public abstract class LoanServiceBase<T, K, P> where T : ItemBase where K : LoanBase, new() where P : PersonBase
{
    private List<T> _items = new();
    private List<K> _activeLoans = new();
    private List<K> _pastLoans = new();
    private List<P> _members = new();

    public LoanServiceBase()
    {
        
    }

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

    public bool RemoveItem(){
        throw new NotImplementedException();
    }

    public bool BorrowItem(string id, string customerId){
        K? loan = _activeLoans.Find((K loan) => loan.Id == id);
        if(loan != null)
        {
            return false;
        }
        else
        {
            var newLoan = new K();
            newLoan.ItemId = id;
            newLoan.CustomerId = customerId;
            _activeLoans.Add(newLoan);
            return true;
        }
    }

    public bool ReturnItem(string id){
        K? loan = _activeLoans.Find((K loan) => loan.Id == id);
        if(loan != null)
        {
            return false;
        }
        else
        {
            _activeLoans.Where((K loan) => loan.Id != id);
            _pastLoans.Add(loan);
            return true;
        }
    }

    public bool AddMember(P person){
        if(_members.Contains(person))
        {
            throw new Exception("Person already added.");
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

    public bool UpdateMember(){
        throw new NotImplementedException();
    }

    public bool RemoveMember(string id){
        if(_members.Exists(person => person.Id == id))
        {
            _members = _members.Where(person => person.Id == id).ToList();
            return true;
        }
        return false;
    }
}