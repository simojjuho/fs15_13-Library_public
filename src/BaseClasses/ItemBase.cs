namespace Base;

public abstract class ItemBase
{
    private string _id;

    public string Id
    {
        get
        {
            return _id;
        }
    }

    public ItemBase(string id)
    {
        _id = id;    
    }    
}