namespace LibraryManagement.BaseClasses;

public abstract class ItemBase
{
    private readonly string _id;
    private readonly bool _canBorrow;

    public bool CanBorrow => _canBorrow;

    public string Id => _id;

    protected ItemBase(bool canBorrow)
    {
        var random = new Random();
        _id = $"{random.Next(1000)}-{random.Next(1000)}-{random.Next(10000)}";
        _canBorrow = canBorrow;
    }    
}