namespace LibraryManagement.BaseClasses;

public abstract class PersonBase
{
    private readonly string _id = string.Empty;
    private string _name;
    
    public string Id => _id;

    public string Name
    {
        get => _name;
        set
        {
            if (value.Length > 1)
            {
                _name = value;
            }
            else
            {
                throw new Exception("New name must be at least 2 letters");
            }
        }
    }

    protected PersonBase(string name)
    {
        var random = new Random();
        _name = name;
        _id = $"{random.Next((10000))}";
    }
}