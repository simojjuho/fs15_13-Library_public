namespace LibraryManagement.BaseClasses;

public abstract class LoanServiceBase<T, TK, TP> where T : ItemBase where TK : LoanBase, new() where TP : PersonBase
{
    private List<T> _items = new();
    private List<TK> _activeLoans = new();
    private List<TK> _pastLoans = new();
    private List<TP> _members = new();

    public LoanServiceBase() {}

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
        var Loan = _activeLoans.Find((TK loan) => loan.Id == id);
        if(Loan != null)
        {
            return false;
        }
        else
        {
            var NewLoan = new TK();
            NewLoan.ItemId = id;
            NewLoan.CustomerId = customerId;
            _activeLoans.Add(NewLoan);
            return true;
        }
    }

    public bool ReturnItem(string id){
        var Loan = _activeLoans.Find((TK loan) => loan.Id == id);
        if(Loan != null)
        {
            return false;
        }
        else
        {
            _activeLoans = _activeLoans.Where((TK loan) => loan.Id != id).ToList();
            _pastLoans.Add(Loan);
            return true;
        }
    }

    public bool AddMember(TP person){
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

    public bool UpdateMember(TP update, string id){
        var Person = GetMemberById(id);

        var UpdateProps = update.GetType().GetProperties();
        var OldProps = Person.GetType().GetProperties();

        foreach(var Property in OldProps)
        {
            if(update.GetType().GetProperty(Property.Name) is not null)
            {
                if(Property.CanWrite)
                {
                    Property.SetValue(Person, update.GetType().GetProperty(Property.Name)!.GetValue(update));
                }
            }
        }
        return true;
    }

    public bool RemoveMember(string id){
        if(_members.Exists(person => person.Id == id))
        {
            _members = _members.Where(person => person.Id == id).ToList();
            return true;
        }
        return false;
    }

    public TP GetMemberById(string id)
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
}